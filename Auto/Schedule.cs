using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Auto
{
    public partial class Schedule : Form
    {
        private SqlConnection sqlConnection;
        private DataGridView dataGridViewSorted;
        private ComboBox comboBoxSortField;
        private RadioButton radioButtonAsc;
        private RadioButton radioButtonDesc;
        private Button btnSort;
        private Button btnStatistics;
        private TextBox textBoxMinPrice;
        private TextBox textBoxMaxPrice;
        private TextBox textBoxMinDate;
        private TextBox textBoxMaxDate;
        private TextBox textBoxMinTime;
        private TextBox textBoxMaxTime;
        private Button btnFilter;
        public Schedule()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection("Data Source=DESKTOP-3LOM13I;Initial Catalog=trasportation;Integrated Security=True");
            sqlConnection.Open();

            LoadScheduleData();
        }

        private void InitializeCustomComponents()
        {
            dataGridViewSorted = new DataGridView
            {
                Location = new Point(20, 250),
                Size = new Size(600, 220),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            Controls.Add(dataGridViewSorted);

            comboBoxSortField = new ComboBox
            {
                Location = new Point(650, 250),
                Width = 150
            };
            comboBoxSortField.Items.AddRange(new string[] { "Ціна", "Дата_перевезення", "Час_відправлення", "Час_прибуття" });
            Controls.Add(comboBoxSortField);

            radioButtonAsc = new RadioButton
            {
                Text = "За зростанням",
                Location = new Point(650, 290),
                AutoSize = true
            };
            Controls.Add(radioButtonAsc);

            radioButtonDesc = new RadioButton
            {
                Text = "За спаданням",
                Location = new Point(650, 310),
                AutoSize = true
            };
            Controls.Add(radioButtonDesc);

            // Initialize Sort Button
            btnSort = new Button
            {
                Text = "Сортувати",
                Location = new Point(650, 340),
                Width = 150
            };
            btnSort.Click += BtnSort_Click;
            Controls.Add(btnSort);

            textBoxMinPrice = new TextBox { Location = new Point(650, 370), Width = 70 };
            SetPlaceholder(textBoxMinPrice, "Мін. ціна");
            Controls.Add(textBoxMinPrice);

            textBoxMaxPrice = new TextBox { Location = new Point(750, 370), Width = 70 };
            SetPlaceholder(textBoxMaxPrice, "Макс. ціна");
            Controls.Add(textBoxMaxPrice);

            textBoxMinDate = new TextBox { Location = new Point(650, 400), Width = 100 };
            SetPlaceholder(textBoxMinDate, "Мін. дата (YYYY-MM-DD)");
            Controls.Add(textBoxMinDate);

            textBoxMaxDate = new TextBox { Location = new Point(730, 400), Width = 100 };
            SetPlaceholder(textBoxMaxDate, "Макс. дата (YYYY-MM-DD)");
            Controls.Add(textBoxMaxDate);

            textBoxMinTime = new TextBox { Location = new Point(650, 430), Width = 70 };
            SetPlaceholder(textBoxMinTime, "Мін. час");
            Controls.Add(textBoxMinTime);

            textBoxMaxTime = new TextBox { Location = new Point(750, 430), Width = 70 };
            SetPlaceholder(textBoxMaxTime, "Макс. час");
            Controls.Add(textBoxMaxTime);

            btnFilter = new Button
            {
                Text = "Фільтрувати",
                Location = new Point(650, 460),
                Width = 150
            };
            btnFilter.Click += BtnFilter_Click;
            Controls.Add(btnFilter);
            btnStatistics = new Button
            {
                Text = "Статистика",
                Location = new Point(650, 490),
                Width = 150
            };
            btnStatistics.Click += BtnStatistics_Click;
            Controls.Add(btnStatistics);
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
                    decimal average = reader.GetDecimal(0);
                    decimal max = reader.GetDecimal(1);
                    decimal min = reader.GetDecimal(2);
                    MessageBox.Show($"Середнє: {average}\nМаксимум: {max}\nМінімум: {min}");
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
        private void SetPlaceholder(TextBox textBox, string placeholder)
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
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void LoadScheduleData()
        {
            string query = @"
        SELECT 
            z.ID_Перевезення AS 'ID Перевезення', -- Display ID_Перевезення
            m.Початкова_точка AS 'Початкова точка', 
            m.Кінцева_точка AS 'Кінцева точка', 
            d.Дата_перевезення AS 'Дата', 
            d.Час_відправлення AS 'Час відправлення', 
            d.Час_прибуття AS 'Час прибуття', 
            d.Статус AS 'Статус', 
            d.Ціна AS 'Ціна'
        FROM 
            Деталі_перевезення d
        JOIN 
            [Зв'язок_перевезень] z ON d.ID_Перевезення = z.ID_Перевезення
        JOIN 
            Маршрут m ON z.ID_Маршруту = m.ID_Маршруту";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            try
            {
                sqlDataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable; 
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
        private void BtnSort_Click(object sender, EventArgs e)
        {
            string sortField = comboBoxSortField.SelectedItem?.ToString();
            string sortOrder = radioButtonAsc.Checked ? "ASC" : "DESC";

            if (string.IsNullOrWhiteSpace(sortField))
            {
                MessageBox.Show("Будь ласка, виберіть поле для сортування.");
                return;
            }
            string sortedQuery = $@"
                SELECT TOP 10 
                    m.Початкова_точка AS 'Початкова точка', 
                    m.Кінцева_точка AS 'Кінцева точка', 
                    d.Дата_перевезення AS 'Дата', 
                    d.Час_відправлення AS 'Час відправлення', 
                    d.Час_прибуття AS 'Час прибуття', 
                    d.Статус AS 'Статус', 
                    d.Ціна AS 'Ціна'
                FROM 
                    Деталі_перевезення d
                JOIN 
                    [Зв'язок_перевезень] z ON d.ID_Перевезення = z.ID_Перевезення
                JOIN 
                    Маршрут m ON z.ID_Маршруту = m.ID_Маршруту
                ORDER BY {sortField} {sortOrder}";

            SqlCommand sqlCommand = new SqlCommand(sortedQuery, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable sortedDataTable = new DataTable();

            try
            {
                sqlConnection.Open();
                sqlDataAdapter.Fill(sortedDataTable);

                dataGridViewSorted.DataSource = sortedDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sorting data: " + ex.Message);
            }
            finally
            {

                sqlConnection.Close();
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            string filterQuery = @"
                SELECT 
                    m.Початкова_точка AS 'Початкова точка', 
                    m.Кінцева_точка AS 'Кінцева точка', 
                    d.Дата_перевезення AS 'Дата', 
                    d.Час_відправлення AS 'Час відправлення', 
                    d.Час_прибуття AS 'Час прибуття', 
                    d.Статус AS 'Статус', 
                    d.Ціна AS 'Ціна'
                FROM 
                    Деталі_перевезення d
                JOIN 
                    [Зв'язок_перевезень] z ON d.ID_Перевезення = z.ID_Перевезення
                JOIN 
                    Маршрут m ON z.ID_Маршруту = m.ID_Маршруту
                WHERE 1=1";

            if (decimal.TryParse(textBoxMinPrice.Text, out decimal minPrice))
                filterQuery += $" AND d.Ціна >= {minPrice}";

            if (decimal.TryParse(textBoxMaxPrice.Text, out decimal maxPrice))
                filterQuery += $" AND d.Ціна <= {maxPrice}";

            if (DateTime.TryParse(textBoxMinDate.Text, out DateTime minDate))
                filterQuery += $" AND d.Дата_перевезення >= '{minDate:yyyy-MM-dd}'";

            if (DateTime.TryParse(textBoxMaxDate.Text, out DateTime maxDate))
                filterQuery += $" AND d.Дата_перевезення <= '{maxDate:yyyy-MM-dd}'";

            if (TimeSpan.TryParse(textBoxMinTime.Text, out TimeSpan minTime))
                filterQuery += $" AND d.Час_відправлення >= '{minTime}'";

            if (TimeSpan.TryParse(textBoxMaxTime.Text, out TimeSpan maxTime))
                filterQuery += $" AND d.Час_відправлення <= '{maxTime}'";

            SqlCommand sqlCommand = new SqlCommand(filterQuery, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable filteredDataTable = new DataTable();

            try
            {
                sqlConnection.Open();
                sqlDataAdapter.Fill(filteredDataTable);
                dataGridViewSorted.DataSource = filteredDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
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


    
    

