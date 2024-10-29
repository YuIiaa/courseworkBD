using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Auto
{
    public partial class Form1 : Form
    {     
        private string connectionString = "Data Source=DESKTOP-3LOM13I;Initial Catalog=trasportation;Integrated Security=True";
        private ComboBox comboBoxStartPoint;
        private ComboBox comboBoxEndPoint;
        private DateTimePicker dateTimePicker;
        private Button buttonSearch;
        private DataGridView dataGridViewResults;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }
        private void InitializeCustomComponents()
        {
            comboBoxStartPoint = new ComboBox { Location = new Point(150, 40), Width = 120 };
            comboBoxEndPoint = new ComboBox { Location = new Point(300, 40), Width = 120 };
            LoadLocations();
            dateTimePicker = new DateTimePicker { Location = new Point(460, 40), Width = 200 };

            buttonSearch = new Button { Location = new Point(680, 40), Text = "Пошук", Width = 100 };
            buttonSearch.Click += ButtonSearch_Click;

            dataGridViewResults = new DataGridView { Location = new Point(150, 80), Size = new Size(500, 100) };

            Controls.Add(comboBoxStartPoint);
            Controls.Add(comboBoxEndPoint);
            Controls.Add(dateTimePicker);
            Controls.Add(buttonSearch);
            Controls.Add(dataGridViewResults);
        }

        private void LoadLocations()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT DISTINCT Початкова_точка FROM Маршрут", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxStartPoint.Items.Add(reader["Початкова_точка"].ToString());
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand("SELECT DISTINCT Кінцева_точка FROM Маршрут", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxEndPoint.Items.Add(reader["Кінцева_точка"].ToString());
                        }
                    }
                }
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string startPoint = comboBoxStartPoint.SelectedItem?.ToString();
            string endPoint = comboBoxEndPoint.SelectedItem?.ToString();
            DateTime selectedDate = dateTimePicker.Value.Date;

            if (string.IsNullOrEmpty(startPoint) || string.IsNullOrEmpty(endPoint))
            {
                MessageBox.Show("Please select both start and end points.");
                return;
            }
            FetchTransportData(startPoint, endPoint, selectedDate);
        }

        private void FetchTransportData(string startPoint, string endPoint, DateTime date)
        {
            string query = @"SELECT d.Час_відправлення, d.Час_прибуття, d.Статус, d.Ціна 
                     FROM Деталі_перевезення d
                     JOIN [Зв'язок_перевезень] z ON d.ID_Перевезення = z.ID_Перевезення
                     JOIN Маршрут m ON z.ID_Маршруту = m.ID_Маршруту
                     WHERE m.Початкова_точка = @StartPoint 
                     AND m.Кінцева_точка = @EndPoint 
                     AND CAST(d.Дата_перевезення AS DATE) = @Date";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartPoint", startPoint);
                command.Parameters.AddWithValue("@EndPoint", endPoint);
                command.Parameters.AddWithValue("@Date", date);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridViewResults.DataSource = dataTable; 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void розкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule formSchedule = new Schedule();
            formSchedule.Show();         
        }     

        private void затримкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Routes formRoutes = new Routes();
            formRoutes.Show();
        }

        private void затримкиЗасобиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delays formDelays = new Delays();
            formDelays.Show();
        }

        private void транспортніЗасобиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicles formVehicles = new Vehicles();
            formVehicles.Show();
        }

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients formClients = new Clients();
            formClients.Show();
        }

        private void платежіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payments formPayments = new Payments();
            formPayments.Show();
        }
    }
}

