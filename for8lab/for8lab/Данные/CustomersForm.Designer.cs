
namespace for8lab
{
    partial class CustomersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customersDispatchersViewTableAdapter = new for8lab.SQL_ShippingDataSetTableAdapters.CustomersDispatchersViewTableAdapter();
            this.dispatchersTableAdapter = new for8lab.SQL_ShippingDataSetTableAdapters.DispatchersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCoWorkTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherWorkTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersDispatchersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_ShippingDataSet1 = new for8lab.SQL_ShippingDataSet();
            this.dispatchersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDispatchersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_ShippingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииToolStripMenuItem,
            this.вернутьсяToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1159, 36);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.опцииToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.добавитьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.изменитьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.удалитьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.вернутьсяToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(118, 32);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Диспетчер:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DataSource = this.dispatchersBindingSource;
            this.comboBox1.DisplayMember = "DispatcherSurname";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 33);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // customersDispatchersViewTableAdapter
            // 
            this.customersDispatchersViewTableAdapter.ClearBeforeFill = true;
            // 
            // dispatchersTableAdapter
            // 
            this.dispatchersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerCoWorkTimeDataGridViewTextBoxColumn,
            this.dispatcherSurnameDataGridViewTextBoxColumn,
            this.dispatcherFirstnameDataGridViewTextBoxColumn,
            this.dispatcherLastnameDataGridViewTextBoxColumn,
            this.dispatcherWorkTimeDataGridViewTextBoxColumn,
            this.dispatcherIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersDispatchersViewBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(17, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 345);
            this.dataGridView1.TabIndex = 7;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerCoWorkTimeDataGridViewTextBoxColumn
            // 
            this.customerCoWorkTimeDataGridViewTextBoxColumn.DataPropertyName = "CustomerCoWorkTime";
            this.customerCoWorkTimeDataGridViewTextBoxColumn.HeaderText = "CustomerCoWorkTime";
            this.customerCoWorkTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerCoWorkTimeDataGridViewTextBoxColumn.Name = "customerCoWorkTimeDataGridViewTextBoxColumn";
            this.customerCoWorkTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerCoWorkTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dispatcherSurnameDataGridViewTextBoxColumn
            // 
            this.dispatcherSurnameDataGridViewTextBoxColumn.DataPropertyName = "DispatcherSurname";
            this.dispatcherSurnameDataGridViewTextBoxColumn.HeaderText = "DispatcherSurname";
            this.dispatcherSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherSurnameDataGridViewTextBoxColumn.Name = "dispatcherSurnameDataGridViewTextBoxColumn";
            this.dispatcherSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.dispatcherSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dispatcherFirstnameDataGridViewTextBoxColumn
            // 
            this.dispatcherFirstnameDataGridViewTextBoxColumn.DataPropertyName = "DispatcherFirstname";
            this.dispatcherFirstnameDataGridViewTextBoxColumn.HeaderText = "DispatcherFirstname";
            this.dispatcherFirstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherFirstnameDataGridViewTextBoxColumn.Name = "dispatcherFirstnameDataGridViewTextBoxColumn";
            this.dispatcherFirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.dispatcherFirstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dispatcherLastnameDataGridViewTextBoxColumn
            // 
            this.dispatcherLastnameDataGridViewTextBoxColumn.DataPropertyName = "DispatcherLastname";
            this.dispatcherLastnameDataGridViewTextBoxColumn.HeaderText = "DispatcherLastname";
            this.dispatcherLastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherLastnameDataGridViewTextBoxColumn.Name = "dispatcherLastnameDataGridViewTextBoxColumn";
            this.dispatcherLastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.dispatcherLastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dispatcherWorkTimeDataGridViewTextBoxColumn
            // 
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.DataPropertyName = "DispatcherWorkTime";
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.HeaderText = "DispatcherWorkTime";
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.Name = "dispatcherWorkTimeDataGridViewTextBoxColumn";
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dispatcherIDDataGridViewTextBoxColumn
            // 
            this.dispatcherIDDataGridViewTextBoxColumn.DataPropertyName = "DispatcherID";
            this.dispatcherIDDataGridViewTextBoxColumn.HeaderText = "DispatcherID";
            this.dispatcherIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherIDDataGridViewTextBoxColumn.Name = "dispatcherIDDataGridViewTextBoxColumn";
            this.dispatcherIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dispatcherIDDataGridViewTextBoxColumn.Visible = false;
            this.dispatcherIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customersDispatchersViewBindingSource
            // 
            this.customersDispatchersViewBindingSource.DataMember = "CustomersDispatchersView";
            this.customersDispatchersViewBindingSource.DataSource = this.sQL_ShippingDataSet1;
            // 
            // sQL_ShippingDataSet1
            // 
            this.sQL_ShippingDataSet1.DataSetName = "SQL_ShippingDataSet";
            this.sQL_ShippingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dispatchersBindingSource
            // 
            this.dispatchersBindingSource.DataMember = "Dispatchers";
            this.dispatchersBindingSource.DataSource = this.sQL_ShippingDataSet1;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1159, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "CustomersForm";
            this.Text = "Заказчики";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDispatchersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_ShippingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        public SQL_ShippingDataSetTableAdapters.CustomersDispatchersViewTableAdapter customersDispatchersViewTableAdapter;
        private SQL_ShippingDataSetTableAdapters.DispatchersTableAdapter dispatchersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQL_ShippingDataSet sQL_ShippingDataSet1;
        private System.Windows.Forms.BindingSource customersDispatchersViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCoWorkTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherWorkTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dispatchersBindingSource;
    }
}