using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Auto
{
    public partial class Delays : Form
    {
        private SqlConnection sqlConnection;
        private Button viewRoutesButton;
        private Button filterButton;
        private Button sortButton; 
        private DataGridView routesDataGridView;
        private TextBox minDelayTextBox;
        private TextBox maxDelayTextBox;
        private RadioButton sortAscendingRadioButton;
        private RadioButton sortDescendingRadioButton;

        public Delays()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=DESKTOP-3LOM13I;Initial Catalog=trasportation;Integrated Security=True");
            InitializeComponents();
        }
        private void InitializeComponents()
        {
            viewRoutesButton = new Button();
            viewRoutesButton.Text = "Перегляд маршрутів із затримками";
            viewRoutesButton.Location = new Point(20, 190);
            viewRoutesButton.Size = new Size(200, 40);
            viewRoutesButton.Click += ViewRoutesButton_Click;

            filterButton = new Button();
            filterButton.Text = "Відбір за затримкою";
            filterButton.Location = new Point(430, 190);
            filterButton.Size = new Size(150, 40);
            filterButton.Click += FilterButton_Click;

            sortButton = new Button();
            sortButton.Text = "Сортувати";
            sortButton.Location = new Point(650, 320);
            sortButton.Size = new Size(150, 40);
            sortButton.Click += SortButton_Click;

            routesDataGridView = new DataGridView();
            routesDataGridView.Location = new Point(20, 270);
            routesDataGridView.Size = new Size(600, 220);
            routesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            minDelayTextBox = new TextBox();
            minDelayTextBox.Location = new Point(240, 190);
            minDelayTextBox.Size = new Size(80, 40);
            SetPlaceholder(minDelayTextBox, "Мін. затримка");

            maxDelayTextBox = new TextBox();
            maxDelayTextBox.Location = new Point(330, 190);
            maxDelayTextBox.Size = new Size(80, 40);
            SetPlaceholder(maxDelayTextBox, "Макс. затримка");

            sortAscendingRadioButton = new RadioButton();
            sortAscendingRadioButton.Text = "За зростанням";
            sortAscendingRadioButton.Location = new Point(650, 270);
            sortAscendingRadioButton.Size = new Size(120, 20); 
            sortAscendingRadioButton.Checked = true; 

            sortDescendingRadioButton = new RadioButton();
            sortDescendingRadioButton.Text = "За спаданням";
            sortDescendingRadioButton.Location = new Point(650, 290);
            sortDescendingRadioButton.Size = new Size(120, 20);

            this.Controls.Add(viewRoutesButton);
            this.Controls.Add(filterButton);
            this.Controls.Add(sortButton); 
            this.Controls.Add(routesDataGridView);
            this.Controls.Add(minDelayTextBox);
            this.Controls.Add(maxDelayTextBox);
            this.Controls.Add(sortAscendingRadioButton); 
            this.Controls.Add(sortDescendingRadioButton); 
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
        private void ViewRoutesButton_Click(object sender, EventArgs e)
        {
            LoadDelayedRoutes();
        }    

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string minDelay = minDelayTextBox.Text == "Мін. затримка" ? null : minDelayTextBox.Text;
            string maxDelay = maxDelayTextBox.Text == "Макс. затримка" ? null : maxDelayTextBox.Text;

            LoadDelayedRoutes(minDelay, maxDelay);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string order = sortAscendingRadioButton.Checked ? "ASC" : "DESC";
            LoadDelayedRoutes(null, null, order);
        }
        private void LoadDelayedRoutes(string minDelay = null, string maxDelay = null, string order = "ASC")
        {
            try
            {
                sqlConnection.Open();
                string query = @"
                    SELECT 
                        m.Початкова_точка AS 'Початкова точка', 
                        m.Кінцева_точка AS 'Кінцева точка', 
                        z.Опис_затримки AS 'Опис затримки', 
                        z.Тривалість_затримки AS 'Час затримки', 
                        z.Дата_та_час_затримки AS 'Дата та час затримки'
                    FROM 
                        Затримка z
                    INNER JOIN 
                        Деталі_перевезення d ON z.ID_Деталі = d.ID_Деталі
                    INNER JOIN 
                        [Зв'язок_перевезень] c ON d.ID_Перевезення = c.ID_Перевезення
                    INNER JOIN 
                        Маршрут m ON c.ID_Маршруту = m.ID_Маршруту
                    WHERE 
                        z.Тривалість_затримки > 0";

                if (!string.IsNullOrEmpty(minDelay) && !string.IsNullOrEmpty(maxDelay))
                {
                    query += " AND z.Тривалість_затримки BETWEEN @minDelay AND @maxDelay";
                }

                query += $" ORDER BY z.Тривалість_затримки {order}";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);

                if (!string.IsNullOrEmpty(minDelay))
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@minDelay", minDelay);
                }
                if (!string.IsNullOrEmpty(maxDelay))
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@maxDelay", maxDelay);
                }

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                routesDataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void Delays_Load(object sender, EventArgs e)
        {
            this.затримкаTableAdapter.Fill(this.trasportationDataSet5.Затримка);
        }
    }
}
