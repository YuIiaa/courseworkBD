namespace Auto
{
    partial class Delays
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
            this.trasportationDataSet5 = new Auto.trasportationDataSet5();
            this.затримкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.затримкаTableAdapter = new Auto.trasportationDataSet5TableAdapters.ЗатримкаTableAdapter();
            this.iDЗатримкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDДеталіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описзатримкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тривалістьзатримкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дататачасзатримкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportationDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.затримкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗатримкиDataGridViewTextBoxColumn,
            this.iDДеталіDataGridViewTextBoxColumn,
            this.описзатримкиDataGridViewTextBoxColumn,
            this.тривалістьзатримкиDataGridViewTextBoxColumn,
            this.дататачасзатримкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.затримкаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // trasportationDataSet5
            // 
            this.trasportationDataSet5.DataSetName = "trasportationDataSet5";
            this.trasportationDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // затримкаBindingSource
            // 
            this.затримкаBindingSource.DataMember = "Затримка";
            this.затримкаBindingSource.DataSource = this.trasportationDataSet5;
            // 
            // затримкаTableAdapter
            // 
            this.затримкаTableAdapter.ClearBeforeFill = true;
            // 
            // iDЗатримкиDataGridViewTextBoxColumn
            // 
            this.iDЗатримкиDataGridViewTextBoxColumn.DataPropertyName = "ID_Затримки";
            this.iDЗатримкиDataGridViewTextBoxColumn.HeaderText = "ID_Затримки";
            this.iDЗатримкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDЗатримкиDataGridViewTextBoxColumn.Name = "iDЗатримкиDataGridViewTextBoxColumn";
            this.iDЗатримкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDЗатримкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDДеталіDataGridViewTextBoxColumn
            // 
            this.iDДеталіDataGridViewTextBoxColumn.DataPropertyName = "ID_Деталі";
            this.iDДеталіDataGridViewTextBoxColumn.HeaderText = "ID_Деталі";
            this.iDДеталіDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDДеталіDataGridViewTextBoxColumn.Name = "iDДеталіDataGridViewTextBoxColumn";
            this.iDДеталіDataGridViewTextBoxColumn.Width = 125;
            // 
            // описзатримкиDataGridViewTextBoxColumn
            // 
            this.описзатримкиDataGridViewTextBoxColumn.DataPropertyName = "Опис_затримки";
            this.описзатримкиDataGridViewTextBoxColumn.HeaderText = "Опис_затримки";
            this.описзатримкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описзатримкиDataGridViewTextBoxColumn.Name = "описзатримкиDataGridViewTextBoxColumn";
            this.описзатримкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // тривалістьзатримкиDataGridViewTextBoxColumn
            // 
            this.тривалістьзатримкиDataGridViewTextBoxColumn.DataPropertyName = "Тривалість_затримки";
            this.тривалістьзатримкиDataGridViewTextBoxColumn.HeaderText = "Тривалість_затримки";
            this.тривалістьзатримкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.тривалістьзатримкиDataGridViewTextBoxColumn.Name = "тривалістьзатримкиDataGridViewTextBoxColumn";
            this.тривалістьзатримкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // дататачасзатримкиDataGridViewTextBoxColumn
            // 
            this.дататачасзатримкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_та_час_затримки";
            this.дататачасзатримкиDataGridViewTextBoxColumn.HeaderText = "Дата_та_час_затримки";
            this.дататачасзатримкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.дататачасзатримкиDataGridViewTextBoxColumn.Name = "дататачасзатримкиDataGridViewTextBoxColumn";
            this.дататачасзатримкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // Delays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 649);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Delays";
            this.Text = "Delays";
            this.Load += new System.EventHandler(this.Delays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportationDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.затримкаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private trasportationDataSet5 trasportationDataSet5;
        private System.Windows.Forms.BindingSource затримкаBindingSource;
        private trasportationDataSet5TableAdapters.ЗатримкаTableAdapter затримкаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗатримкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDДеталіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описзатримкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тривалістьзатримкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дататачасзатримкиDataGridViewTextBoxColumn;
    }
}