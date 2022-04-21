using System;
using System.Windows.Forms;

namespace for8lab
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }
        public System.Data.SqlClient.SqlConnection connect;
        private void Base_Load(object sender, EventArgs e)
        {
            String connectionString = "Data Source=DESKTOP-ESRKVOG;Initial Catalog=SQL_Shipping;Integrated Security=True";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMeForm aboutMe = new AboutMeForm();
            aboutMe.Show();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void диспетчерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DispatchersForm dispatchers = new DispatchersForm();
            dispatchers.Show();
        }
        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriversForm drivers = new DriversForm();
            drivers.Show();
        }
        private void заказчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm customers = new CustomersForm();
            customers.Show();
        }
        private void грузыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargoesForm cargoes = new CargoesForm();
            cargoes.Show();
        }
        private void экспортВExcelИHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportForm exportForm = new ExportForm();
            exportForm.Show();
        }
        private void отчетОЗаказчикахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersReportForm customersReportForm = new CustomersReportForm();
            customersReportForm.Show();
        }
        private void отчетОГрузахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargoesReportForm cargoesReportForm = new CargoesReportForm();
            cargoesReportForm.Show();
        }
    }
}