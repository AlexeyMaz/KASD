
namespace for8lab
{
    partial class Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диспетчерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грузыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВExcelИHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетCrystalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОЗаказчикахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОГрузахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.данныеToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.BackColor = global::for8lab.Properties.Settings.Default.Lime;
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.диспетчерыToolStripMenuItem,
            this.водителиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справочникиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // диспетчерыToolStripMenuItem
            // 
            this.диспетчерыToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.диспетчерыToolStripMenuItem.Name = "диспетчерыToolStripMenuItem";
            this.диспетчерыToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.диспетчерыToolStripMenuItem.Text = "Диспетчеры";
            this.диспетчерыToolStripMenuItem.Click += new System.EventHandler(this.диспетчерыToolStripMenuItem_Click);
            // 
            // водителиToolStripMenuItem
            // 
            this.водителиToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.водителиToolStripMenuItem.Name = "водителиToolStripMenuItem";
            this.водителиToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.водителиToolStripMenuItem.Text = "Водители";
            this.водителиToolStripMenuItem.Click += new System.EventHandler(this.водителиToolStripMenuItem_Click);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказчикиToolStripMenuItem,
            this.грузыToolStripMenuItem});
            this.данныеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.данныеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(98, 32);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // заказчикиToolStripMenuItem
            // 
            this.заказчикиToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.заказчикиToolStripMenuItem.Name = "заказчикиToolStripMenuItem";
            this.заказчикиToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.заказчикиToolStripMenuItem.Text = "Заказчики";
            this.заказчикиToolStripMenuItem.Click += new System.EventHandler(this.заказчикиToolStripMenuItem_Click);
            // 
            // грузыToolStripMenuItem
            // 
            this.грузыToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.грузыToolStripMenuItem.Name = "грузыToolStripMenuItem";
            this.грузыToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.грузыToolStripMenuItem.Text = "Грузы";
            this.грузыToolStripMenuItem.Click += new System.EventHandler(this.грузыToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортВExcelИHTMLToolStripMenuItem,
            this.отчетCrystalReportToolStripMenuItem});
            this.отчетыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(92, 32);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // экспортВExcelИHTMLToolStripMenuItem
            // 
            this.экспортВExcelИHTMLToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.экспортВExcelИHTMLToolStripMenuItem.Name = "экспортВExcelИHTMLToolStripMenuItem";
            this.экспортВExcelИHTMLToolStripMenuItem.Size = new System.Drawing.Size(310, 32);
            this.экспортВExcelИHTMLToolStripMenuItem.Text = "Экспорт в Excel и HTML";
            this.экспортВExcelИHTMLToolStripMenuItem.Click += new System.EventHandler(this.экспортВExcelИHTMLToolStripMenuItem_Click);
            // 
            // отчетCrystalReportToolStripMenuItem
            // 
            this.отчетCrystalReportToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.отчетCrystalReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетОЗаказчикахToolStripMenuItem,
            this.отчетОГрузахToolStripMenuItem});
            this.отчетCrystalReportToolStripMenuItem.Name = "отчетCrystalReportToolStripMenuItem";
            this.отчетCrystalReportToolStripMenuItem.Size = new System.Drawing.Size(310, 32);
            this.отчетCrystalReportToolStripMenuItem.Text = "Отчет Crystal Report";
            // 
            // отчетОЗаказчикахToolStripMenuItem
            // 
            this.отчетОЗаказчикахToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.отчетОЗаказчикахToolStripMenuItem.Name = "отчетОЗаказчикахToolStripMenuItem";
            this.отчетОЗаказчикахToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.отчетОЗаказчикахToolStripMenuItem.Text = "Отчет о заказчиках";
            this.отчетОЗаказчикахToolStripMenuItem.Click += new System.EventHandler(this.отчетОЗаказчикахToolStripMenuItem_Click);
            // 
            // отчетОГрузахToolStripMenuItem
            // 
            this.отчетОГрузахToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.отчетОГрузахToolStripMenuItem.Name = "отчетОГрузахToolStripMenuItem";
            this.отчетОГрузахToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.отчетОГрузахToolStripMenuItem.Text = "Отчет о грузах";
            this.отчетОГрузахToolStripMenuItem.Click += new System.EventHandler(this.отчетОГрузахToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(150, 32);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 163);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Base";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.Base_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диспетчерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказчикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грузыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортВExcelИHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетCrystalReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОЗаказчикахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОГрузахToolStripMenuItem;
    }
}

