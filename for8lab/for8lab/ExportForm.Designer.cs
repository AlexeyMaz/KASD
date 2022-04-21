
namespace for8lab
{
    partial class ExportForm
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHTML = new System.Windows.Forms.RadioButton();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.sqL_ShippingDataSet1 = new for8lab.SQL_ShippingDataSet();
            this.cargoesViewTableAdapter1 = new for8lab.SQL_ShippingDataSetTableAdapters.CargoesViewTableAdapter();
            this.customersViewTableAdapter1 = new for8lab.SQL_ShippingDataSetTableAdapters.CustomersViewTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqL_ShippingDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(24, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(621, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Список заказчиков, сотрудничество с которыми ведется более 5 лет";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox2.Location = new System.Drawing.Point(25, 89);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(413, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Список грузов, вес которых превышает 10 кг.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHTML);
            this.groupBox1.Controls.Add(this.rbExcel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(25, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Форма экспорта";
            // 
            // rbHTML
            // 
            this.rbHTML.AutoSize = true;
            this.rbHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbHTML.Location = new System.Drawing.Point(6, 61);
            this.rbHTML.Name = "rbHTML";
            this.rbHTML.Size = new System.Drawing.Size(168, 24);
            this.rbHTML.TabIndex = 1;
            this.rbHTML.TabStop = true;
            this.rbHTML.Text = "Экспорт в HTML";
            this.rbHTML.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbExcel.Location = new System.Drawing.Point(6, 31);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(162, 24);
            this.rbExcel.TabIndex = 0;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "Экспорт в Excel";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(313, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqL_ShippingDataSet1
            // 
            this.sqL_ShippingDataSet1.DataSetName = "SQL_ShippingDataSet";
            this.sqL_ShippingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargoesViewTableAdapter1
            // 
            this.cargoesViewTableAdapter1.ClearBeforeFill = true;
            // 
            // customersViewTableAdapter1
            // 
            this.customersViewTableAdapter1.ClearBeforeFill = true;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqL_ShippingDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHTML;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.Button button1;
        private SQL_ShippingDataSet sqL_ShippingDataSet1;
        private SQL_ShippingDataSetTableAdapters.CargoesViewTableAdapter cargoesViewTableAdapter1;
        private SQL_ShippingDataSetTableAdapters.CustomersViewTableAdapter customersViewTableAdapter1;
    }
}