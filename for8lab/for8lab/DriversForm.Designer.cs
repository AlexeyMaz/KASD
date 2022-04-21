
namespace for8lab
{
    partial class DriversForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriversForm));
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_ShippingDataSet = new for8lab.SQL_ShippingDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьИзменениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargoesTableAdapter = new for8lab.SQL_ShippingDataSetTableAdapters.CargoesTableAdapter();
            this.sQLShippingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driversTableAdapter = new for8lab.SQL_ShippingDataSetTableAdapters.DriversTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.driverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverWorkTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driversBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_ShippingDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLShippingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.sQL_ShippingDataSet;
            // 
            // sQL_ShippingDataSet
            // 
            this.sQL_ShippingDataSet.DataSetName = "SQL_ShippingDataSet";
            this.sQL_ShippingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИзменениеToolStripMenuItem,
            this.удалитьЗаписьToolStripMenuItem,
            this.вернутьсяToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьИзменениеToolStripMenuItem
            // 
            this.сохранитьИзменениеToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.сохранитьИзменениеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сохранитьИзменениеToolStripMenuItem.Name = "сохранитьИзменениеToolStripMenuItem";
            this.сохранитьИзменениеToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.сохранитьИзменениеToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзменениеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.удалитьЗаписьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            this.удалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписьToolStripMenuItem_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.вернутьсяToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(118, 32);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.выйтиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.выйтиToolStripMenuItem.Text = "Выйти из проекта";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // cargoesBindingSource
            // 
            this.cargoesBindingSource.DataMember = "Cargoes";
            this.cargoesBindingSource.DataSource = this.sQL_ShippingDataSet;
            // 
            // cargoesTableAdapter
            // 
            this.cargoesTableAdapter.ClearBeforeFill = true;
            // 
            // sQLShippingDataSetBindingSource
            // 
            this.sQLShippingDataSetBindingSource.DataSource = this.sQL_ShippingDataSet;
            this.sQLShippingDataSetBindingSource.Position = 0;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driverIDDataGridViewTextBoxColumn,
            this.driverSurnameDataGridViewTextBoxColumn,
            this.driverFirstnameDataGridViewTextBoxColumn,
            this.driverLastnameDataGridViewTextBoxColumn,
            this.driverWorkTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.driversBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1132, 537);
            this.dataGridView1.TabIndex = 2;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            this.driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            this.driverIDDataGridViewTextBoxColumn.HeaderText = "DriverID";
            this.driverIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            this.driverIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverSurnameDataGridViewTextBoxColumn
            // 
            this.driverSurnameDataGridViewTextBoxColumn.DataPropertyName = "DriverSurname";
            this.driverSurnameDataGridViewTextBoxColumn.HeaderText = "DriverSurname";
            this.driverSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverSurnameDataGridViewTextBoxColumn.Name = "driverSurnameDataGridViewTextBoxColumn";
            this.driverSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverFirstnameDataGridViewTextBoxColumn
            // 
            this.driverFirstnameDataGridViewTextBoxColumn.DataPropertyName = "DriverFirstname";
            this.driverFirstnameDataGridViewTextBoxColumn.HeaderText = "DriverFirstname";
            this.driverFirstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverFirstnameDataGridViewTextBoxColumn.Name = "driverFirstnameDataGridViewTextBoxColumn";
            this.driverFirstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverLastnameDataGridViewTextBoxColumn
            // 
            this.driverLastnameDataGridViewTextBoxColumn.DataPropertyName = "DriverLastname";
            this.driverLastnameDataGridViewTextBoxColumn.HeaderText = "DriverLastname";
            this.driverLastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverLastnameDataGridViewTextBoxColumn.Name = "driverLastnameDataGridViewTextBoxColumn";
            this.driverLastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverWorkTimeDataGridViewTextBoxColumn
            // 
            this.driverWorkTimeDataGridViewTextBoxColumn.DataPropertyName = "DriverWorkTime";
            this.driverWorkTimeDataGridViewTextBoxColumn.HeaderText = "DriverWorkTime";
            this.driverWorkTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverWorkTimeDataGridViewTextBoxColumn.Name = "driverWorkTimeDataGridViewTextBoxColumn";
            this.driverWorkTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // driversBindingSource1
            // 
            this.driversBindingSource1.DataMember = "Drivers";
            this.driversBindingSource1.DataSource = this.sQL_ShippingDataSet;
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 573);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DriversForm";
            this.Text = "Водители";
            this.Load += new System.EventHandler(this.Drivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_ShippingDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLShippingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SQL_ShippingDataSet sQL_ShippingDataSet;
        private System.Windows.Forms.BindingSource cargoesBindingSource;
        private SQL_ShippingDataSetTableAdapters.CargoesTableAdapter cargoesTableAdapter;
        private System.Windows.Forms.BindingSource sQLShippingDataSetBindingSource;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private SQL_ShippingDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзменениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverWorkTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource driversBindingSource1;
    }
}