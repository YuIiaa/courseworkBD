namespace Auto
{
    partial class Clients
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
            this.trasportationDataSet7 = new Auto.trasportationDataSet7();
            this.клієнтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клієнтTableAdapter = new Auto.trasportationDataSet7TableAdapters.КлієнтTableAdapter();
            this.iDКлієнтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.електроннапоштаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportationDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлієнтаDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.прізвищеDataGridViewTextBoxColumn,
            this.номертелефонуDataGridViewTextBoxColumn,
            this.електроннапоштаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клієнтBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(910, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // trasportationDataSet7
            // 
            this.trasportationDataSet7.DataSetName = "trasportationDataSet7";
            this.trasportationDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клієнтBindingSource
            // 
            this.клієнтBindingSource.DataMember = "Клієнт";
            this.клієнтBindingSource.DataSource = this.trasportationDataSet7;
            // 
            // клієнтTableAdapter
            // 
            this.клієнтTableAdapter.ClearBeforeFill = true;
            // 
            // iDКлієнтаDataGridViewTextBoxColumn
            // 
            this.iDКлієнтаDataGridViewTextBoxColumn.DataPropertyName = "ID_Клієнта";
            this.iDКлієнтаDataGridViewTextBoxColumn.HeaderText = "ID_Клієнта";
            this.iDКлієнтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDКлієнтаDataGridViewTextBoxColumn.Name = "iDКлієнтаDataGridViewTextBoxColumn";
            this.iDКлієнтаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDКлієнтаDataGridViewTextBoxColumn.Width = 125;
            // 
            // імяDataGridViewTextBoxColumn
            // 
            this.імяDataGridViewTextBoxColumn.DataPropertyName = "Ім_я";
            this.імяDataGridViewTextBoxColumn.HeaderText = "Ім_я";
            this.імяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.імяDataGridViewTextBoxColumn.Name = "імяDataGridViewTextBoxColumn";
            this.імяDataGridViewTextBoxColumn.Width = 125;
            // 
            // прізвищеDataGridViewTextBoxColumn
            // 
            this.прізвищеDataGridViewTextBoxColumn.DataPropertyName = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.прізвищеDataGridViewTextBoxColumn.Name = "прізвищеDataGridViewTextBoxColumn";
            this.прізвищеDataGridViewTextBoxColumn.Width = 125;
            // 
            // номертелефонуDataGridViewTextBoxColumn
            // 
            this.номертелефонуDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефону";
            this.номертелефонуDataGridViewTextBoxColumn.HeaderText = "Номер_телефону";
            this.номертелефонуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номертелефонуDataGridViewTextBoxColumn.Name = "номертелефонуDataGridViewTextBoxColumn";
            this.номертелефонуDataGridViewTextBoxColumn.Width = 125;
            // 
            // електроннапоштаDataGridViewTextBoxColumn
            // 
            this.електроннапоштаDataGridViewTextBoxColumn.DataPropertyName = "Електронна_пошта";
            this.електроннапоштаDataGridViewTextBoxColumn.HeaderText = "Електронна_пошта";
            this.електроннапоштаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.електроннапоштаDataGridViewTextBoxColumn.Name = "електроннапоштаDataGridViewTextBoxColumn";
            this.електроннапоштаDataGridViewTextBoxColumn.Width = 125;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 555);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportationDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private trasportationDataSet7 trasportationDataSet7;
        private System.Windows.Forms.BindingSource клієнтBindingSource;
        private trasportationDataSet7TableAdapters.КлієнтTableAdapter клієнтTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлієнтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn електроннапоштаDataGridViewTextBoxColumn;
    }
}