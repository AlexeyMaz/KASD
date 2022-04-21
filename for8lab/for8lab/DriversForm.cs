using System;
using System.Windows.Forms;

namespace for8lab
{
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();
        }
        private void Drivers_Load(object sender, EventArgs e)
        {
            this.driversTableAdapter.Fill(this.sQL_ShippingDataSet.Drivers);
            dataGridView1.Columns[0].HeaderText = "Код водителя";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Фамилия водителя";
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].HeaderText = "Имя водителя";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "Отчество водителя";
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].HeaderText = "Дата приема водителя на работу";
            dataGridView1.Columns[4].Width = 150;
        }
        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = sQL_ShippingDataSet.Drivers;
                driversTableAdapter.Update(sQL_ShippingDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                driversTableAdapter.Update(sQL_ShippingDataSet);
            }
        }
        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}