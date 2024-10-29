namespace Auto
{
    partial class Payments
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
            this.trasportationDataSet8 = new Auto.trasportationDataSet8();
            this.платіжBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.платіжTableAdapter = new Auto.trasportationDataSet8TableAdapters.ПлатіжTableAdapter();
            this.iDПлатежуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПеревезенняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сумаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаплатежуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спосібплатежуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportationDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.платіжBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПлатежуDataGridViewTextBoxColumn,
            this.iDПеревезенняDataGridViewTextBoxColumn,
            this.сумаDataGridViewTextBoxColumn,
            this.датаплатежуDataGridViewTextBoxColumn,
            this.спосібплатежуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.платіжBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // trasportationDataSet8
            // 
            this.trasportationDataSet8.DataSetName = "trasportationDataSet8";
            this.trasportationDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // платіжBindingSource
            // 
            this.платіжBindingSource.DataMember = "Платіж";
            this.платіжBindingSource.DataSource = this.trasportationDataSet8;
            // 
            // платіжTableAdapter
            // 
            this.платіжTableAdapter.ClearBeforeFill = true;
            // 
            // iDПлатежуDataGridViewTextBoxColumn
            // 
            this.iDПлатежуDataGridViewTextBoxColumn.DataPropertyName = "ID_Платежу";
            this.iDПлатежуDataGridViewTextBoxColumn.HeaderText = "ID_Платежу";
            this.iDПлатежуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПлатежуDataGridViewTextBoxColumn.Name = "iDПлатежуDataGridViewTextBoxColumn";
            this.iDПлатежуDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDПлатежуDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDПеревезенняDataGridViewTextBoxColumn
            // 
            this.iDПеревезенняDataGridViewTextBoxColumn.DataPropertyName = "ID_Перевезення";
            this.iDПеревезенняDataGridViewTextBoxColumn.HeaderText = "ID_Перевезення";
            this.iDПеревезенняDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПеревезенняDataGridViewTextBoxColumn.Name = "iDПеревезенняDataGridViewTextBoxColumn";
            this.iDПеревезенняDataGridViewTextBoxColumn.Width = 125;
            // 
            // сумаDataGridViewTextBoxColumn
            // 
            this.сумаDataGridViewTextBoxColumn.DataPropertyName = "Сума";
            this.сумаDataGridViewTextBoxColumn.HeaderText = "Сума";
            this.сумаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сумаDataGridViewTextBoxColumn.Name = "сумаDataGridViewTextBoxColumn";
            this.сумаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаплатежуDataGridViewTextBoxColumn
            // 
            this.датаплатежуDataGridViewTextBoxColumn.DataPropertyName = "Дата_платежу";
            this.датаплатежуDataGridViewTextBoxColumn.HeaderText = "Дата_платежу";
            this.датаплатежуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаплатежуDataGridViewTextBoxColumn.Name = "датаплатежуDataGridViewTextBoxColumn";
            this.датаплатежуDataGridViewTextBoxColumn.Width = 125;
            // 
            // спосібплатежуDataGridViewTextBoxColumn
            // 
            this.спосібплатежуDataGridViewTextBoxColumn.DataPropertyName = "Спосіб_платежу";
            this.спосібплатежуDataGridViewTextBoxColumn.HeaderText = "Спосіб_платежу";
            this.спосібплатежуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.спосібплатежуDataGridViewTextBoxColumn.Name = "спосібплатежуDataGridViewTextBoxColumn";
            this.спосібплатежуDataGridViewTextBoxColumn.Width = 125;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 557);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportationDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.платіжBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private trasportationDataSet8 trasportationDataSet8;
        private System.Windows.Forms.BindingSource платіжBindingSource;
        private trasportationDataSet8TableAdapters.ПлатіжTableAdapter платіжTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПлатежуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПеревезенняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сумаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаплатежуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спосібплатежуDataGridViewTextBoxColumn;
    }
}