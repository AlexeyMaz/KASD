using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace for8lab
{
    public partial class CargoesForm : Form
    {
        public CargoesForm()
        {
            InitializeComponent();
        }
        private void CargoesForm_Load(object sender, EventArgs e)
        {
            this.driversTableAdapter.Fill(this.sQL_ShippingDataSet.Drivers);
            this.cargoesDriversViewTableAdapter.Fill(this.sQL_ShippingDataSet1.CargoesDriversView);
            dataGridView1.Columns[0].HeaderText = "Код груза";
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].HeaderText = "Пункт назначения";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Вес груза";
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].HeaderText = "Фамилия водителя";
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].HeaderText = "Имя водителя";
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].HeaderText = "Отчество водителя";
            dataGridView1.Columns[5].Width = 140;
            dataGridView1.Columns[6].HeaderText = "Дата приема водителя на работу";
            dataGridView1.Columns[6].Width = 150;
        }
        SqlDataAdapter dataAdapter = null;
        private void UpdateView()//для выборки
        {
            dataAdapter = new SqlDataAdapter("SELECT CargoID, Destination, CargoWeight, DriverSurname, DriverFirstname, DriverLastname, DriverWorkTime, DriverID FROM CargoesDriversView WHERE DriverSurname = '" + comboBox1.Text + "'", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        public void UpdateView1()//для опций
        {
            dataAdapter = new SqlDataAdapter("SELECT CargoID, Destination, CargoWeight, DriverSurname, DriverFirstname, DriverLastname, DriverWorkTime, DriverID FROM CargoesDriversView", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
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
                g = new AddCargo(null, null, DispatcherID).ShowDialog();
            }
            else
                g = new AddCargo(null, null, null).ShowDialog();
            this.cargoesDriversViewTableAdapter.Fill(this.sQL_ShippingDataSet1.CargoesDriversView);
            if (dataAdapter != null) UpdateView1();
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CargoDestination = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string CargoWeight = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string DriverID = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            DialogResult g = new AddCargo(CargoDestination, CargoWeight, DriverID).ShowDialog();
            this.cargoesDriversViewTableAdapter.Fill(this.sQL_ShippingDataSet1.CargoesDriversView);
            if (dataAdapter != null) UpdateView1();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Удалить текущую запись с ID " + s + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "DELETE FROM Cargoes WHERE CargoID = " + s;
                SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                int number = command.ExecuteNonQuery();
            }
            this.cargoesDriversViewTableAdapter.Fill(this.sQL_ShippingDataSet1.CargoesDriversView);
            if (dataAdapter != null) UpdateView1();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            изменитьToolStripMenuItem_Click(sender, e);
        }
    }
}