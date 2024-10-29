using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Auto
{
    public partial class Routes : Form
    {
         private SqlConnection sqlConnection;
        private TextBox textBoxDistance;
        private Button buttonGroup, buttonSort;
        private DataGridView dataGridViewRoutes2;
        private RadioButton radioButtonAsc, radioButtonDesc;
        public Routes()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=DESKTOP-3LOM13I;Initial Catalog=trasportation;Integrated Security=True");

            Button buttonStops = new Button
            {
                Location = new System.Drawing.Point(350, 300),
                Size = new System.Drawing.Size(150, 30),
                Text = "Дізнатись зупинки"
            };
            buttonStops.Click += new EventHandler(buttonStops_Click);
            this.Controls.Add(buttonStops);

            textBoxDistance = new TextBox
            {
                Location = new System.Drawing.Point(20, 300),
                Size = new System.Drawing.Size(200, 30),
                Text = "Введіть відстань" 
            };
            textBoxDistance.Enter += TextBoxDistance_Enter; 
            textBoxDistance.Leave += TextBoxDistance_Leave; 
            this.Controls.Add(textBoxDistance);


            buttonGroup = new Button
            {
                Location = new System.Drawing.Point(230, 300),
                Size = new System.Drawing.Size(100, 30),
                Text = "Групувати"
            };
            buttonGroup.Click += new EventHandler(buttonGroup_Click);
            this.Controls.Add(buttonGroup);
   
            radioButtonAsc = new RadioButton
            {
                Location = new System.Drawing.Point(20, 260),
                Size = new System.Drawing.Size(120, 20),
                Text = "За зростанням",
                Checked = true 
            };
            this.Controls.Add(radioButtonAsc);

            radioButtonDesc = new RadioButton
            {
                Location = new System.Drawing.Point(140, 260),
                Size = new System.Drawing.Size(120, 20),
                Text = "За спаданням"
            };
            this.Controls.Add(radioButtonDesc);

            buttonSort = new Button
            {
                Location = new System.Drawing.Point(270, 260),
                Size = new System.Drawing.Size(100, 30),
                Text = "Сортувати"
            };
            buttonSort.Click += new EventHandler(buttonSort_Click);
            this.Controls.Add(buttonSort);

            dataGridViewRoutes2 = new DataGridView
            {
                Location = new System.Drawing.Point(20, 350),
                Size = new System.Drawing.Size(600, 150),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            this.Controls.Add(dataGridViewRoutes2);

        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            LoadSortedRoutesData();
        }
        private void LoadSortedRoutesData()
        {
            string sortOrder = radioButtonAsc.Checked ? "ASC" : "DESC";
            string query = $@"
                SELECT Початкова_точка,
                       Кінцева_точка,
                       Відстань
                FROM Маршрут
                ORDER BY Відстань {sortOrder}";

            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridViewRoutes2.DataSource = null;
                dataGridViewRoutes2.DataSource = dataTable;
            }
        }
        private void TextBoxDistance_Enter(object sender, EventArgs e)
        {
            if (textBoxDistance.Text == "Введіть відстань") 
            {
                textBoxDistance.Text = ""; 
                textBoxDistance.ForeColor = System.Drawing.Color.Black; 
            }
        }
        private void TextBoxDistance_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDistance.Text)) 
            {
                textBoxDistance.Text = "Введіть відстань"; 
                textBoxDistance.ForeColor = System.Drawing.Color.Gray; 
            }
        }
        private void buttonStops_Click(object sender, EventArgs e)
        {
            LoadStopDetails();
        }
        private void LoadStopDetails()
        {
            string query = @"
        SELECT m.Початкова_точка AS Початкова_точка,
               z.Місце_зупинки AS Зупинка,
               m.Кінцева_точка AS Кінцева_точка,
               m.Відстань AS Відстань
        FROM Маршрут m
        LEFT JOIN Зупинка z ON m.ID_Маршруту = z.ID_Маршруту
        ORDER BY m.Початкова_точка, z.Порядок_зупинки";

            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridViewRoutes2.DataSource = null;
                dataGridViewRoutes2.DataSource = dataTable;
            }
        }
        private void Routes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trasportationDataSet4.Маршрут". При необходимости она может быть перемещена или удалена.
            this.маршрутTableAdapter.Fill(this.trasportationDataSet4.Маршрут);
            LoadRoutesData();
        }
        private void buttonGroup_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxDistance.Text, out double distance))
            {
                LoadGroupedRoutesData(distance);
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть дійсне числове значення для відстані.");
            }
        }

        private void LoadGroupedRoutesData(double distance)
        {
            string query = @"
        SELECT m.Початкова_точка, 
               m.Кінцева_точка,
               m.Відстань,
               COUNT(*) AS Кількість_перевезень
        FROM Маршрут m
        GROUP BY m.Початкова_точка, 
                 m.Кінцева_точка, 
                 m.Відстань
        HAVING m.Відстань = @distance";

            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@distance", distance);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridViewRoutes2.DataSource = null;

                dataGridViewRoutes2.DataSource = dataTable;
            }
        }
        private void LoadRoutesData()
        {         
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

