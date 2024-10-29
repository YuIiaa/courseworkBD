namespace Auto
{
    partial class Vehicles
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
            this.trasportationDataSet6 = new Auto.trasportationDataSet6();
            this.транспортнийзасібBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.транспортний_засібTableAdapter = new Auto.trasportationDataSet6TableAdapters.Транспортний_засібTableAdapter();
            this.iDТЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номернийзнакDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ріквипускуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вантажопідйомністьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportationDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортнийзасібBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТЗDataGridViewTextBoxColumn,
            this.номернийзнакDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.ріквипускуDataGridViewTextBoxColumn,
            this.вантажопідйомністьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.транспортнийзасібBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trasportationDataSet6
            // 
            this.trasportationDataSet6.DataSetName = "trasportationDataSet6";
            this.trasportationDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // транспортнийзасібBindingSource
            // 
            this.транспортнийзасібBindingSource.DataMember = "Транспортний_засіб";
            this.транспортнийзасібBindingSource.DataSource = this.trasportationDataSet6;
            // 
            // транспортний_засібTableAdapter
            // 
            this.транспортний_засібTableAdapter.ClearBeforeFill = true;
            // 
            // iDТЗDataGridViewTextBoxColumn
            // 
            this.iDТЗDataGridViewTextBoxColumn.DataPropertyName = "ID_ТЗ";
            this.iDТЗDataGridViewTextBoxColumn.HeaderText = "ID_ТЗ";
            this.iDТЗDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDТЗDataGridViewTextBoxColumn.Name = "iDТЗDataGridViewTextBoxColumn";
            this.iDТЗDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТЗDataGridViewTextBoxColumn.Width = 125;
            // 
            // номернийзнакDataGridViewTextBoxColumn
            // 
            this.номернийзнакDataGridViewTextBoxColumn.DataPropertyName = "Номерний_знак";
            this.номернийзнакDataGridViewTextBoxColumn.HeaderText = "Номерний_знак";
            this.номернийзнакDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номернийзнакDataGridViewTextBoxColumn.Name = "номернийзнакDataGridViewTextBoxColumn";
            this.номернийзнакDataGridViewTextBoxColumn.Width = 125;
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            this.модельDataGridViewTextBoxColumn.Width = 125;
            // 
            // ріквипускуDataGridViewTextBoxColumn
            // 
            this.ріквипускуDataGridViewTextBoxColumn.DataPropertyName = "Рік_випуску";
            this.ріквипускуDataGridViewTextBoxColumn.HeaderText = "Рік_випуску";
            this.ріквипускуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ріквипускуDataGridViewTextBoxColumn.Name = "ріквипускуDataGridViewTextBoxColumn";
            this.ріквипускуDataGridViewTextBoxColumn.Width = 125;
            // 
            // вантажопідйомністьDataGridViewTextBoxColumn
            // 
            this.вантажопідйомністьDataGridViewTextBoxColumn.DataPropertyName = "Вантажопідйомність";
            this.вантажопідйомністьDataGridViewTextBoxColumn.HeaderText = "Вантажопідйомність";
            this.вантажопідйомністьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.вантажопідйомністьDataGridViewTextBoxColumn.Name = "вантажопідйомністьDataGridViewTextBoxColumn";
            this.вантажопідйомністьDataGridViewTextBoxColumn.Width = 125;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 653);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportationDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортнийзасібBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private trasportationDataSet6 trasportationDataSet6;
        private System.Windows.Forms.BindingSource транспортнийзасібBindingSource;
        private trasportationDataSet6TableAdapters.Транспортний_засібTableAdapter транспортний_засібTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номернийзнакDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ріквипускуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вантажопідйомністьDataGridViewTextBoxColumn;
    }
}