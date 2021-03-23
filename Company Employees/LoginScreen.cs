using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Employees
{
    public partial class LoginScreen : Form
    {
        EmployeeOperations operations = new EmployeeOperations();
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            label_warning.Text = "";
            string userName = tb_username.Text;
            string password = tb_password.Text;

            bool loginStatus = operations.login(userName,password);

            if(loginStatus == true)
            {
                EmployeeScreen employeeScreen = new EmployeeScreen();
                this.Hide();
                employeeScreen.Show();
            }
            else
            {
                label_warning.Text = "Giriş Başarısız. Lütfen tekrar deneyiniz..";
            }
        }
    }
}
