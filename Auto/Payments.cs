using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

       namespace Auto
        {
        public partial class Payments : Form
        {
            private SqlConnection sqlConnection;
            private DataGridView dataGridViewPayments;
            private TextBox textBoxMinPayment, textBoxMaxPayment;
            private Button buttonFilterPayments, buttonSortPayments;
            private RadioButton radioButtonSortAscending, radioButtonSortDescending;
            private Button buttonCalculateStatistics;
        public Payments()
            {
                InitializeComponent();
                sqlConnection = new SqlConnection("Data Source=DESKTOP-3LOM13I;Initial Catalog=trasportation;Integrated Security=True");
                this.Text = "Payments Information";
                this.Size = new Size(800, 450);

                InitializeDataGridView();
                InitializeFilterControls();
                InitializeSortControls();
            }

            private void Payments_Load(object sender, EventArgs e)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "trasportationDataSet8.Платіж". При необходимости она может быть перемещена или удалена.
                this.платіжTableAdapter.Fill(this.trasportationDataSet8.Платіж);
                LoadPaymentData();
            }
            private void InitializeDataGridView()
            {
                dataGridViewPayments = new DataGridView
                {
                    Location = new Point(20, 250),
                    Size = new Size(600, 250),
                    ReadOnly = true,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                };
                this.Controls.Add(dataGridViewPayments);
            }

            private void InitializeFilterControls()
            {
                textBoxMinPayment = new TextBox { Location = new Point(650, 250), Width = 100 };
                textBoxMaxPayment = new TextBox { Location = new Point(650, 280), Width = 100 };
                buttonFilterPayments = new Button { Location = new Point(650, 310), Width = 100, Text = "Фільтрувати" };

                buttonFilterPayments.Click += ButtonFilterPayments_Click;

                SetPlaceholderText(textBoxMinPayment, "Мін. сума");
                SetPlaceholderText(textBoxMaxPayment, "Макс. сума");

                this.Controls.Add(textBoxMinPayment);
                this.Controls.Add(textBoxMaxPayment);
                this.Controls.Add(buttonFilterPayments);
            }

            private void InitializeSortControls()
            {
                radioButtonSortAscending = new RadioButton
                {
                    Location = new Point(650, 350),
                    Text = "За зростанням",
                    Checked = true 
                };
                radioButtonSortDescending = new RadioButton
                {
                    Location = new Point(650, 370),
                    Text = "За спаданням"
                };

                buttonSortPayments = new Button
                {
                    Location = new Point(650, 400),
                    Width = 100,
                    Text = "Сортувати дату"
                };

                buttonSortPayments.Click += ButtonSortPayments_Click;

                this.Controls.Add(radioButtonSortAscending);
                this.Controls.Add(radioButtonSortDescending);
                this.Controls.Add(buttonSortPayments);

            buttonCalculateStatistics = new Button
            {
                Location = new Point(650, 430),
                Width = 100,
                Text = "Розрахувати"
            };

            buttonCalculateStatistics.Click += BtnStatistics_Click;

            this.Controls.Add(buttonCalculateStatistics);
        }
        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            string numericField = "Ціна"; 

            string statisticsQuery = $@"
    SELECT 
        AVG(d.{numericField}) AS 'Середнє', 
        MAX(d.{numericField}) AS 'Максимум', 
        MIN(d.{numericField}) AS 'Мінімум' 
    FROM 
        Деталі_перевезення d";

            SqlCommand sqlCommand = new SqlCommand(statisticsQuery, sqlConnection);
            try
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    decimal average = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                    decimal max = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                    decimal min = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                    MessageBox.Show($"Середнє: {average:F2}\nМаксимум: {max:F2}\nМінімум: {min:F2}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching statistics: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }        
        private void SetPlaceholderText(TextBox textBox, string placeholder)
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray; 
                textBox.Enter += (sender, e) =>
                {
                    if (textBox.Text == placeholder)
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black; 
                    }
                };

                textBox.Leave += (sender, e) =>
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = placeholder;
                        textBox.ForeColor = Color.Gray;
                    }
                };
            }
            private void ButtonFilterPayments_Click(object sender, EventArgs e)
            {
                LoadPaymentData();
            }
            private void ButtonSortPayments_Click(object sender, EventArgs e)
            {
                LoadPaymentData(); 
            }
            private void LoadPaymentData()
            {
                string orderBy = radioButtonSortAscending.Checked ? "ASC" : "DESC";
                string query = $@"
                SELECT 
                    [Зв'язок_перевезень].[ID_Перевезення], 
                    [Маршрут].[Початкова_точка], 
                    [Маршрут].[Кінцева_точка], 
                    [Платіж].[Сума], 
                    [Платіж].[Дата_платежу], 
                    [Платіж].[Спосіб_платежу] 
                FROM [Зв'язок_перевезень]
                INNER JOIN [Маршрут] ON [Зв'язок_перевезень].[ID_Маршруту] = [Маршрут].[ID_Маршруту]
                INNER JOIN [Платіж] ON [Зв'язок_перевезень].[ID_Перевезення] = [Платіж].[ID_Перевезення]
                WHERE ([Платіж].[Сума] >= @MinPayment OR @MinPayment IS NULL)
                AND ([Платіж].[Сума] <= @MaxPayment OR @MaxPayment IS NULL)
                ORDER BY [Платіж].[Дата_платежу] {orderBy};";
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        decimal minPayment;
                        decimal maxPayment;

                        bool minParsed = decimal.TryParse(textBoxMinPayment.Text, out minPayment);
                        bool maxParsed = decimal.TryParse(textBoxMaxPayment.Text, out maxPayment);

                        command.Parameters.AddWithValue("@MinPayment", minParsed ? (object)minPayment : DBNull.Value);
                        command.Parameters.AddWithValue("@MaxPayment", maxParsed ? (object)maxPayment : DBNull.Value);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridViewPayments.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
    }
