using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace for8lab
{
    public partial class AddCargo : Form
    {
        string m_CargoDestination;
        string m_CargoWeight;
        string m_DriverID;
        public AddCargo(string CargoDestination, string CargoWeight, string DriverID)
        {
            InitializeComponent();
            m_CargoDestination = CargoDestination;
            m_CargoWeight = CargoWeight;
            m_DriverID = DriverID;
            //try
            //{
            if (m_CargoDestination != null && m_CargoWeight != null)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT DriverID, Destination, CargoWeight " +
                " FROM CargoesDriversView WHERE Destination = '" + m_CargoDestination + "'";
                cmd.Connection = Program.MainForm.connect;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    m_DriverID = rd.GetValue(0).ToString();
                    comboBox1.SelectedValue = m_DriverID;
                    textBox1.Text = (rd.GetValue(1).ToString().Trim());
                    textBox2.Text = (rd.GetValue(2).ToString().Trim());
                }
                rd.Close();
            }
            if (DriverID != null)
                comboBox1.SelectedValue = DriverID;
            //}
            //catch (System.Data.Common.DbException)
            //{
            //    MessageBox.Show("Ошибка доступа к БД");
            //}
        }
        private void AddCargo_Load(object sender, EventArgs e)
        {
            this.driversTableAdapter.Fill(this.sQL_ShippingDataSet.Drivers);
        }
        private void button1_Click(object sender, EventArgs e)//OK
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите пункт назначения груза.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Введите вес груза.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Введите данные о водителе.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlCommand command;
            if (m_CargoDestination != null && m_CargoWeight != null)
            { //Изменение
                string sqlExpression = "UPDATE Cargoes " +
                    "SET DriverID = " + comboBox1.SelectedValue +
                    ", Destination = '" + textBox1.Text + "'" +
                    ", CargoWeight = " + textBox2.Text.ToString() +
                    " WHERE Destination = '" + m_CargoDestination + "' and DriverID = " + m_DriverID;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            }
            else
            { //Добавление
                string sqlExpression = "INSERT INTO Cargoes (DriverID, Destination, CargoWeight) " +
                                       "VALUES (@driver, @dest, @weight)";
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                SqlParameter Param;
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@driver", comboBox1.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@dest", textBox1.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@weight", textBox2.Text.ToString());
                command.Parameters.Add(Param);
            }
            int number = command.ExecuteNonQuery();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)//Cancel
        {
            this.Close();
        }
    }
}