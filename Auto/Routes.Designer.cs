namespace Auto
{
    partial class Routes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDМаршрутуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.початковаточкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кінцеваточкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.відстаньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маршрутBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trasportationDataSet4 = new Auto.trasportationDataSet4();
            this.маршрутTableAdapter = new Auto.trasportationDataSet4TableAdapters.МаршрутTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportationDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМаршрутуDataGridViewTextBoxColumn,
            this.початковаточкаDataGridViewTextBoxColumn,
            this.кінцеваточкаDataGridViewTextBoxColumn,
            this.відстаньDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.маршрутBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDМаршрутуDataGridViewTextBoxColumn
            // 
            this.iDМаршрутуDataGridViewTextBoxColumn.DataPropertyName = "ID_Маршруту";
            this.iDМаршрутуDataGridViewTextBoxColumn.HeaderText = "ID_Маршруту";
            this.iDМаршрутуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDМаршрутуDataGridViewTextBoxColumn.Name = "iDМаршрутуDataGridViewTextBoxColumn";
            this.iDМаршрутуDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМаршрутуDataGridViewTextBoxColumn.Width = 125;
            // 
            // початковаточкаDataGridViewTextBoxColumn
            // 
            this.початковаточкаDataGridViewTextBoxColumn.DataPropertyName = "Початкова_точка";
            this.початковаточкаDataGridViewTextBoxColumn.HeaderText = "Початкова_точка";
            this.початковаточкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.початковаточкаDataGridViewTextBoxColumn.Name = "початковаточкаDataGridViewTextBoxColumn";
            this.початковаточкаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кінцеваточкаDataGridViewTextBoxColumn
            // 
            this.кінцеваточкаDataGridViewTextBoxColumn.DataPropertyName = "Кінцева_точка";
            this.кінцеваточкаDataGridViewTextBoxColumn.HeaderText = "Кінцева_точка";
            this.кінцеваточкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кінцеваточкаDataGridViewTextBoxColumn.Name = "кінцеваточкаDataGridViewTextBoxColumn";
            this.кінцеваточкаDataGridViewTextBoxColumn.Width = 125;
            // 
            // відстаньDataGridViewTextBoxColumn
            // 
            this.відстаньDataGridViewTextBoxColumn.DataPropertyName = "Відстань";
            this.відстаньDataGridViewTextBoxColumn.HeaderText = "Відстань";
            this.відстаньDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.відстаньDataGridViewTextBoxColumn.Name = "відстаньDataGridViewTextBoxColumn";
            this.відстаньDataGridViewTextBoxColumn.Width = 125;
            // 
            // маршрутBindingSource
            // 
            this.маршрутBindingSource.DataMember = "Маршрут";
            this.маршрутBindingSource.DataSource = this.trasportationDataSet4;
            // 
            // trasportationDataSet4
            // 
            this.trasportationDataSet4.DataSetName = "trasportationDataSet4";
            this.trasportationDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // маршрутTableAdapter
            // 
            this.маршрутTableAdapter.ClearBeforeFill = true;
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 638);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Routes";
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportationDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private trasportationDataSet4 trasportationDataSet4;
        private System.Windows.Forms.BindingSource маршрутBindingSource;
        private trasportationDataSet4TableAdapters.МаршрутTableAdapter маршрутTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМаршрутуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn початковаточкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кінцеваточкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn відстаньDataGridViewTextBoxColumn;
    }
}