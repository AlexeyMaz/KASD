using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace for8lab
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            this.customersDispatchersViewTableAdapter.Fill(this.sQL_ShippingDataSet1.CustomersDispatchersView);
            this.dispatchersTableAdapter.Fill(this.sQL_ShippingDataSet1.Dispatchers);
            dataGridView1.Columns[0].HeaderText = "Код заказчика";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Дата заключения договора";
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].HeaderText = "Фамилия диспетчера";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "Имя диспетчера";
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].HeaderText = "Отчество диспетчера";
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].HeaderText = "Дата приема диспетчера на работу";
            dataGridView1.Columns[5].Width = 140;
        }
        SqlDataAdapter dataAdapter = null;
        public void UpdateView()//для выборки
        {
            dataAdapter = new SqlDataAdapter("SELECT CustomerID, CustomerCoWorkTime, DispatcherSurname, DispatcherFirstname, DispatcherLastname, DispatcherWorkTime, DispatcherID FROM CustomersDispatchersView WHERE DispatcherSurname = '" + comboBox1.Text + "'", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        public void UpdateView1()//для опций
        {
            dataAdapter = new SqlDataAdapter("SELECT CustomerID, CustomerCoWorkTime, DispatcherSurname, DispatcherFirstname, DispatcherLastname, DispatcherWorkTime, DispatcherID FROM CustomersDispatchersView", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void вернутьсяToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string DispatcherID;
            DialogResult g;
            if (!(comboBox1.SelectedIndex < 0))
            {
                DispatcherID = comboBox1.SelectedValue.ToString();
                g = new AddCustomer(null, DispatcherID).ShowDialog();
            }
            else
                g = new AddCustomer(null, null).ShowDialog();
            this.customersDispatchersViewTableAdapter.Fill(this.sQL_ShippingDataSet1.CustomersDispatchersView);
            if (dataAdapter != null) UpdateView1();
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CustomerTime = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string DispatcherID = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            DialogResult g = new AddCustomer(CustomerTime, DispatcherID).ShowDialog();
            this.customersDispatchersViewTableAdapter.Fill(this.sQL_ShippingDataSet1.CustomersDispatchersView);
            if (dataAdapter != null) UpdateView1();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Удалить текущую запись с ID " + s + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "DELETE FROM Customers WHERE CustomerID = " + s;
                SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                int number = command.ExecuteNonQuery();
            }
            this.customersDispatchersViewTableAdapter.Fill(this.sQL_ShippingDataSet1.CustomersDispatchersView);
            if (dataAdapter != null) UpdateView1();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            изменитьToolStripMenuItem_Click(sender, e);
        }
    }
}