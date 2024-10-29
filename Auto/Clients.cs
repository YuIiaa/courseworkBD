using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Auto
{
    public partial class Clients : Form
    {
        private SqlConnection sqlConnection;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private TextBox phoneTextBox;
        private Button searchButton;
        private Button clearButton;
        private RadioButton ascendingRadioButton;
        private RadioButton descendingRadioButton;
        private Button sortButton;
        public Clients()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=DESKTOP-3LOM13I;Initial Catalog=trasportation;Integrated Security=True");
            InitializeSearchControls();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trasportationDataSet7.Клієнт". При необходимости она может быть перемещена или удалена.
            this.клієнтTableAdapter.Fill(this.trasportationDataSet7.Клієнт);
            LoadAllData();
        }
        private void InitializeSearchControls()
        {
            Label nameLabel = new Label
            {
                Text = "Ім'я:",
                Location = new System.Drawing.Point(20, 20)
            };
            Controls.Add(nameLabel);

            nameTextBox = new TextBox
            {
                Location = new System.Drawing.Point(150, 20), 
                Width = 150
            };
            Controls.Add(nameTextBox);

            Label surnameLabel = new Label
            {
                Text = "Прізвище:",
                Location = new System.Drawing.Point(20, 50)
            };
            Controls.Add(surnameLabel);

            surnameTextBox = new TextBox
            {
                Location = new System.Drawing.Point(150, 50), 
                Width = 150
            };
            Controls.Add(surnameTextBox);

            Label phoneLabel = new Label
            {
                Text = "Номер телефону:",
                Location = new System.Drawing.Point(20, 80)
            };
            Controls.Add(phoneLabel);

            phoneTextBox = new TextBox
            {
                Location = new System.Drawing.Point(150, 80),
                Width = 150
            };
            Controls.Add(phoneTextBox);

            searchButton = new Button
            {
                Text = "Пошук",
                Location = new System.Drawing.Point(20, 110),
                Size = new System.Drawing.Size(80, 30)
            };
            searchButton.Click += SearchButton_Click;
            Controls.Add(searchButton);

            clearButton = new Button
            {
                Text = "Очистити",
                Location = new System.Drawing.Point(110, 110),
                Size = new System.Drawing.Size(80, 30)
            };
            clearButton.Click += ClearButton_Click;
            Controls.Add(clearButton);

            ascendingRadioButton = new RadioButton
            {
                Text = "По зростанню",
                Location = new System.Drawing.Point(350, 30)
            };
            Controls.Add(ascendingRadioButton);

            descendingRadioButton = new RadioButton
            {
                Text = "По спаданню",
                Location = new System.Drawing.Point(350, 50)
            };
            Controls.Add(descendingRadioButton);

            sortButton = new Button
            {
                Text = "Сортувати",
                Location = new System.Drawing.Point(350, 80),
                Size = new System.Drawing.Size(80, 30)
            };
            sortButton.Click += SortButton_Click;
            Controls.Add(sortButton);

        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            surnameTextBox.Clear();
            phoneTextBox.Clear();
            LoadAllData();
        }
        private void LoadAllData()
        {
            try
            {
                string query = "SELECT * FROM Клієнт";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні даних: " + ex.Message);
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string surname = surnameTextBox.Text.Trim();
            string phone = phoneTextBox.Text.Trim();

            string query = "SELECT * FROM Клієнт WHERE 1=1";
            if (!string.IsNullOrEmpty(name))
                query += " AND Ім_я LIKE @Name";
            if (!string.IsNullOrEmpty(surname))
                query += " AND Прізвище LIKE @Surname";
            if (!string.IsNullOrEmpty(phone))
                query += " AND Номер_телефону LIKE @Phone";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);

                if (!string.IsNullOrEmpty(name))
                    command.Parameters.AddWithValue("@Name", "%" + name + "%");
                if (!string.IsNullOrEmpty(surname))
                    command.Parameters.AddWithValue("@Surname", "%" + surname + "%");
                if (!string.IsNullOrEmpty(phone))
                    command.Parameters.AddWithValue("@Phone", "%" + phone + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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
            string sortOrder = ascendingRadioButton.Checked ? "ASC" : "DESC";
            try
            {
                string query = $"SELECT * FROM Клієнт ORDER BY Прізвище {sortOrder}";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при сортуванні даних: " + ex.Message);
            }
        }
    }
}


