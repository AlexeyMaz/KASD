using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace for8lab
{
    public partial class AddCustomer : Form
    {
        string m_CustomerTime;
        string m_DispatcherID;
        public AddCustomer(string CustomerTime, string DispatcherID)
        {
            InitializeComponent();
            m_CustomerTime = CustomerTime;
            m_DispatcherID = DispatcherID;
            try
            {
                if (m_CustomerTime != null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT DispatcherID, CustomerCoWorkTime " +
                    " FROM CustomersDispatchersView WHERE CustomerCoWorkTime = '" + CustomerTime + "'";
                    cmd.Connection = Program.MainForm.connect;
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        m_DispatcherID = rd.GetValue(0).ToString();
                        comboBox1.SelectedValue = m_DispatcherID;
                        textBox1.Text = (rd.GetValue(1).ToString().Trim());
                    }
                    rd.Close();
                }
                if (DispatcherID != null)
                    comboBox1.SelectedValue = DispatcherID;
            }
            catch (System.Data.Common.DbException)
            {
                MessageBox.Show("Ошибка доступа к БД");
            }
        }
        public void AddCustomer_Load(object sender, EventArgs e)
        {
            this.dispatchersTableAdapter.Fill(this.sQL_ShippingDataSet.Dispatchers);
        }
        private void button1_Click(object sender, EventArgs e)//OK
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите дату заключения договора с заказчиком.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Введите данные о диспетчере.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlCommand command;
            if (m_CustomerTime != null)
            { //Изменение
                string sqlExpression = "UPDATE Customers " +
                    "SET DispatcherID = " + comboBox1.SelectedValue +
                    ", CustomerCoWorkTime = '" + textBox1.Text + "'" +
                    " WHERE CustomerCoWorkTime = '" + m_CustomerTime + "' and DispatcherID = " + m_DispatcherID;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            }
            else
            { //Добавление
                string sqlExpression = "INSERT INTO Customers (DispatcherID, CustomerCoWorkTime) " +
                                       "VALUES (@disp, @cust)";
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                SqlParameter Param;
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@disp", comboBox1.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@cust", textBox1.Text);
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