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
    public partial class Vehicles : Form
    {
        private SqlConnection sqlConnection;
        private DataGridView dataGridView;
        private ComboBox fieldComboBox;
        private RadioButton ascRadioButton;
        private RadioButton descRadioButton;
        private Button sortButton;
        private Button loadButton;
        private TextBox minValueTextBox;
        private TextBox maxValueTextBox;
        private Button filterButton;
        public Vehicles()
        {
            InitializeComponent();
            
            sqlConnection = new SqlConnection("Data Source=DESKTOP-3LOM13I;Initial Catalog=trasportation;Integrated Security=True");
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trasportationDataSet6.Транспортний_засіб". При необходимости она может быть перемещена или удалена.
            this.транспортний_засібTableAdapter.Fill(this.trasportationDataSet6.Транспортний_засіб);
            dataGridView = new DataGridView
            {
                Location = new System.Drawing.Point(20, 250),
                Size = new System.Drawing.Size(600, 250),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            Controls.Add(dataGridView);

            loadButton = new Button
            {
                Text = "Завантажити дані",
                Location = new System.Drawing.Point(20, 210),
                Size = new System.Drawing.Size(120, 30)
            };
            loadButton.Click += LoadButton_Click;
            Controls.Add(loadButton);
            fieldComboBox = new ComboBox
            {
                Location = new System.Drawing.Point(150, 210),
                Size = new System.Drawing.Size(150, 30)
            };
            fieldComboBox.Items.AddRange(new string[] { "Номерний_знак", "Модель", "Рік_випуску", "Вантажопідйомність" });
            fieldComboBox.SelectedIndex = 0; 
            Controls.Add(fieldComboBox);

            ascRadioButton = new RadioButton
            {
                Text = "За зростанням",
                Location = new System.Drawing.Point(320, 200),
                Checked = true 
            };
            Controls.Add(ascRadioButton);

            descRadioButton = new RadioButton
            {
                Text = "За спаданням",
                Location = new System.Drawing.Point(320, 220)
            };
            Controls.Add(descRadioButton);

            sortButton = new Button
            {
                Text = "Сортувати",
                Location = new System.Drawing.Point(430, 210),
                Size = new System.Drawing.Size(120, 30)
            };
            sortButton.Click += SortButton_Click;
            Controls.Add(sortButton);

            minValueTextBox = new TextBox
            {
                Location = new System.Drawing.Point(650, 250),
                Size = new System.Drawing.Size(80, 30),
                Text = "Мінімум",
                ForeColor = Color.Gray
            };
            minValueTextBox.Enter += (s, eng) =>
            {
                if (minValueTextBox.Text == "Мінімум")
                {
                    minValueTextBox.Text = "";
                    minValueTextBox.ForeColor = Color.Black;
                }
            };
            minValueTextBox.Leave += (s, eng) =>
            {
                if (string.IsNullOrWhiteSpace(minValueTextBox.Text))
                {
                    minValueTextBox.Text = "Мінімум";
                    minValueTextBox.ForeColor = Color.Gray;
                }
            };
            Controls.Add(minValueTextBox);

            maxValueTextBox = new TextBox
            {
                Location = new System.Drawing.Point(740, 250),
                Size = new System.Drawing.Size(80, 30),
                Text = "Максимум",
                ForeColor = Color.Gray
            };
            maxValueTextBox.Enter += (s, eng) =>
            {
                if (maxValueTextBox.Text == "Максимум")
                {
                    maxValueTextBox.Text = "";
                    maxValueTextBox.ForeColor = Color.Black;
                }
            };
            maxValueTextBox.Leave += (s, eng) =>
            {
                if (string.IsNullOrWhiteSpace(maxValueTextBox.Text))
                {
                    maxValueTextBox.Text = "Максимум";
                    maxValueTextBox.ForeColor = Color.Gray;
                }
            };
            Controls.Add(maxValueTextBox);

            filterButton = new Button
            {
                Text = "Фільтрувати",
                Location = new System.Drawing.Point(650, 280),
                Size = new System.Drawing.Size(120, 30)
            };
            filterButton.Click += FilterButton_Click;
            Controls.Add(filterButton);

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string query = @"
    SELECT Маршрут.Початкова_точка, Маршрут.Кінцева_точка, Транспортний_засіб.Модель, Транспортний_засіб.Номерний_знак
    FROM [Зв'язок_перевезень]
    INNER JOIN Маршрут ON [Зв'язок_перевезень].ID_Маршруту = Маршрут.ID_Маршруту
    INNER JOIN Транспортний_засіб ON [Зв'язок_перевезень].ID_ТЗ = Транспортний_засіб.ID_ТЗ";

            try
            {
                sqlConnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні даних: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void SortButton_Click(object sender, EventArgs e)
        {
            string sortField = fieldComboBox.SelectedItem.ToString();
            string sortOrder = ascRadioButton.Checked ? "ASC" : "DESC";

            string query = $@"
            SELECT Номерний_знак, Модель, Рік_випуску, Вантажопідйомність
            FROM Транспортний_засіб
            ORDER BY {sortField} {sortOrder}";

            ExecuteQuery(query);
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(minValueTextBox.Text, out int minValue) && int.TryParse(maxValueTextBox.Text, out int maxValue))
            {
                string query = $@"
                SELECT Номерний_знак, Модель, Рік_випуску, Вантажопідйомність
                FROM Транспортний_засіб
                WHERE Рік_випуску BETWEEN {minValue} AND {maxValue} OR Вантажопідйомність BETWEEN {minValue} AND {maxValue}";

                ExecuteQuery(query);
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні мінімальне і максимальне значення.");
            }
        }
        private void ExecuteQuery(string query)
        {
            try
            {
                sqlConnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні даних: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
