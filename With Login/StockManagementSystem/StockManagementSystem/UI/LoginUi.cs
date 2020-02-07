using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Manager;
using StockManagementSystem.Model;

namespace StockManagementSystem.UI
{
    public partial class LoginUi : Form
    {

        Registration _registration = new Registration();
        LoginAndRegistrationManager _loginAndRegistrationManager = new LoginAndRegistrationManager();

        public LoginUi()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            _registration.Email = emailTextBox.Text;
            _registration.Password = passwordTextBox.Text;

            try
            {
                if (_loginAndRegistrationManager.Login(_registration))
                {
                    MessageBox.Show(@"Login Successfully");
                    HomeUi homeUi=new HomeUi();
                    this.Hide();
                    homeUi.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show(@"Email or Password is not valid !");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void registerNowButton_Click(object sender, EventArgs e)
        {
            RegistrationUi registrationUi=new RegistrationUi();
            this.Hide();
            registrationUi.ShowDialog();
        }
    }
}
