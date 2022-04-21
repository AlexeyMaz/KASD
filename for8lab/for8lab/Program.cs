using System;
using System.Windows.Forms;
namespace for8lab
{
    static class Program
    {
        public static Base MainForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new Base();
            Application.Run(MainForm);
        }
    }
}
