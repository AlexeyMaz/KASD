
namespace for8lab
{
    partial class DispatchersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispatchersForm));
            this.dispatchersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_ShippingDataSet = new for8lab.SQL_ShippingDataSet();
            this.dispatchersTableAdapter = new for8lab.SQL_ShippingDataSetTableAdapters.DispatchersTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьИзменениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dispatcherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatcherWorkTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dispatchersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_ShippingDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dispatchersBindingSource
            // 
            this.dispatchersBindingSource.DataMember = "Dispatchers";
            this.dispatchersBindingSource.DataSource = this.sQL_ShippingDataSet;
            // 
            // sQL_ShippingDataSet
            // 
            this.sQL_ShippingDataSet.DataSetName = "SQL_ShippingDataSet";
            this.sQL_ShippingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dispatchersTableAdapter
            // 
            this.dispatchersTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.TabIndex = 2;
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
            // dispatchersBindingSource1
            // 
            this.dispatchersBindingSource1.DataMember = "Dispatchers";
            this.dispatchersBindingSource1.DataSource = this.sQL_ShippingDataSet;
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
            this.dispatcherIDDataGridViewTextBoxColumn,
            this.dispatcherSurnameDataGridViewTextBoxColumn,
            this.dispatcherFirstnameDataGridViewTextBoxColumn,
            this.dispatcherLastnameDataGridViewTextBoxColumn,
            this.dispatcherWorkTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dispatchersBindingSource2;
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
            this.dataGridView1.TabIndex = 3;
            // 
            // dispatcherIDDataGridViewTextBoxColumn
            // 
            this.dispatcherIDDataGridViewTextBoxColumn.DataPropertyName = "DispatcherID";
            this.dispatcherIDDataGridViewTextBoxColumn.HeaderText = "DispatcherID";
            this.dispatcherIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherIDDataGridViewTextBoxColumn.Name = "dispatcherIDDataGridViewTextBoxColumn";
            this.dispatcherIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dispatcherIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dispatcherSurnameDataGridViewTextBoxColumn
            // 
            this.dispatcherSurnameDataGridViewTextBoxColumn.DataPropertyName = "DispatcherSurname";
            this.dispatcherSurnameDataGridViewTextBoxColumn.HeaderText = "DispatcherSurname";
            this.dispatcherSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherSurnameDataGridViewTextBoxColumn.Name = "dispatcherSurnameDataGridViewTextBoxColumn";
            this.dispatcherSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dispatcherFirstnameDataGridViewTextBoxColumn
            // 
            this.dispatcherFirstnameDataGridViewTextBoxColumn.DataPropertyName = "DispatcherFirstname";
            this.dispatcherFirstnameDataGridViewTextBoxColumn.HeaderText = "DispatcherFirstname";
            this.dispatcherFirstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherFirstnameDataGridViewTextBoxColumn.Name = "dispatcherFirstnameDataGridViewTextBoxColumn";
            this.dispatcherFirstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dispatcherLastnameDataGridViewTextBoxColumn
            // 
            this.dispatcherLastnameDataGridViewTextBoxColumn.DataPropertyName = "DispatcherLastname";
            this.dispatcherLastnameDataGridViewTextBoxColumn.HeaderText = "DispatcherLastname";
            this.dispatcherLastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherLastnameDataGridViewTextBoxColumn.Name = "dispatcherLastnameDataGridViewTextBoxColumn";
            this.dispatcherLastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dispatcherWorkTimeDataGridViewTextBoxColumn
            // 
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.DataPropertyName = "DispatcherWorkTime";
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.HeaderText = "DispatcherWorkTime";
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.Name = "dispatcherWorkTimeDataGridViewTextBoxColumn";
            this.dispatcherWorkTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dispatchersBindingSource2
            // 
            this.dispatchersBindingSource2.DataMember = "Dispatchers";
            this.dispatchersBindingSource2.DataSource = this.sQL_ShippingDataSet;
            // 
            // DispatchersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 573);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DispatchersForm";
            this.Text = "Диспетчеры";
            this.Load += new System.EventHandler(this.Dispatchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dispatchersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_ShippingDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SQL_ShippingDataSet sQL_ShippingDataSet;
        private System.Windows.Forms.BindingSource dispatchersBindingSource;
        private SQL_ShippingDataSetTableAdapters.DispatchersTableAdapter dispatchersTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзменениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dispatchersBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatcherWorkTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dispatchersBindingSource2;
    }
}