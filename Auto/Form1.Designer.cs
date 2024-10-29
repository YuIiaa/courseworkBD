namespace Auto
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.розкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.затримкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транспортніЗасобиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nf_optovikDataSet2 = new Auto.nf_optovikDataSet2();
            this.маршрутTableAdapter = new Auto.nf_optovikDataSet2TableAdapters.МаршрутTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nf_optovikDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розкладToolStripMenuItem,
            this.маршрутиToolStripMenuItem,
            this.затримкиToolStripMenuItem,
            this.транспортніЗасобиToolStripMenuItem,
            this.клієнтиToolStripMenuItem,
            this.платежіToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(171, 439);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // розкладToolStripMenuItem
            // 
            this.розкладToolStripMenuItem.Name = "розкладToolStripMenuItem";
            this.розкладToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.розкладToolStripMenuItem.Text = "Розклад";
            this.розкладToolStripMenuItem.Click += new System.EventHandler(this.розкладToolStripMenuItem_Click);
            // 
            // маршрутиToolStripMenuItem
            // 
            this.маршрутиToolStripMenuItem.Name = "маршрутиToolStripMenuItem";
            this.маршрутиToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.маршрутиToolStripMenuItem.Text = "Маршрути";
            this.маршрутиToolStripMenuItem.Click += new System.EventHandler(this.затримкиToolStripMenuItem_Click);
            // 
            // затримкиToolStripMenuItem
            // 
            this.затримкиToolStripMenuItem.Name = "затримкиToolStripMenuItem";
            this.затримкиToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.затримкиToolStripMenuItem.Text = "Затримки";
            this.затримкиToolStripMenuItem.Click += new System.EventHandler(this.затримкиЗасобиToolStripMenuItem_Click);
            // 
            // транспортніЗасобиToolStripMenuItem
            // 
            this.транспортніЗасобиToolStripMenuItem.Name = "транспортніЗасобиToolStripMenuItem";
            this.транспортніЗасобиToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.транспортніЗасобиToolStripMenuItem.Text = "Транспортні засоби";
            this.транспортніЗасобиToolStripMenuItem.Click += new System.EventHandler(this.транспортніЗасобиToolStripMenuItem_Click);
            // 
            // клієнтиToolStripMenuItem
            // 
            this.клієнтиToolStripMenuItem.Name = "клієнтиToolStripMenuItem";
            this.клієнтиToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.клієнтиToolStripMenuItem.Text = "Клієнти";
            this.клієнтиToolStripMenuItem.Click += new System.EventHandler(this.клієнтиToolStripMenuItem_Click);
            // 
            // платежіToolStripMenuItem
            // 
            this.платежіToolStripMenuItem.Name = "платежіToolStripMenuItem";
            this.платежіToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.платежіToolStripMenuItem.Text = "Платежі";
            this.платежіToolStripMenuItem.Click += new System.EventHandler(this.платежіToolStripMenuItem_Click);
            // 
            // маршрутBindingSource
            // 
            this.маршрутBindingSource.DataMember = "Маршрут";
            this.маршрутBindingSource.DataSource = this.nf_optovikDataSet2;
            // 
            // nf_optovikDataSet2
            // 
            this.nf_optovikDataSet2.DataSetName = "nf_optovikDataSet2";
            this.nf_optovikDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // маршрутTableAdapter
            // 
            this.маршрутTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 439);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nf_optovikDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private nf_optovikDataSet2 nf_optovikDataSet2;
        private System.Windows.Forms.BindingSource маршрутBindingSource;
        private nf_optovikDataSet2TableAdapters.МаршрутTableAdapter маршрутTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem розкладToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem затримкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транспортніЗасобиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежіToolStripMenuItem;
    }
}

