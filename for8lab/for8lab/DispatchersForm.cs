using System;
using System.Windows.Forms;

namespace for8lab
{
    public partial class DispatchersForm : Form
    {
        public DispatchersForm()
        {
            InitializeComponent();
        }
        private void Dispatchers_Load(object sender, EventArgs e)
        {
            this.dispatchersTableAdapter.Fill(this.sQL_ShippingDataSet.Dispatchers);
            dataGridView1.Columns[0].HeaderText = "Код диспетчера";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].HeaderText = "Фамилия диспетчера";
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].HeaderText = "Имя диспетчера";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "Отчество диспетчера";
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].HeaderText = "Дата приема диспетчера на работу";
            dataGridView1.Columns[4].Width = 140;
        }
        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = sQL_ShippingDataSet.Dispatchers;
                dispatchersTableAdapter.Update(sQL_ShippingDataSet);
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
                dispatchersTableAdapter.Update(sQL_ShippingDataSet);
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