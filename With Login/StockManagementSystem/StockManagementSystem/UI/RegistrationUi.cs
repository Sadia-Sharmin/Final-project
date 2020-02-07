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
    public partial class RegistrationUi : Form
    {
        Registration _registration=new Registration();
        LoginAndRegistrationManager _loginAndRegistrationManager=new LoginAndRegistrationManager();

        public RegistrationUi()
        {
            InitializeComponent();

            confirmError.Text = "";
            nameError.Text = "";
            emailError.Text = "";
            passwordError.Text = "";
            registrationErrorMessage.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            _registration.Name = nameTextBox.Text;
            _registration.Email = emailTextBox.Text;
            _registration.Password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(_registration.Name))
            {
                nameError.Text = @"Enter name !";
                nameTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_registration.Email))
            {
                emailError.Text = @"Enter email !";
                emailTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_registration.Password))
            {
                passwordError.Text = @"Enter password !";
                passwordTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(confirmPasswordTextBox.Text))
            {
                confirmError.Text = @"Enter confirm password !";
                confirmPasswordTextBox.Focus();
                return;
            }

            if (_registration.Password != confirmPasswordTextBox.Text)
            {
                registrationErrorMessage.Text = @"Passwprd did not matched !";
                confirmPasswordTextBox.Focus();
                return;
            }

            try
            {
                if (_loginAndRegistrationManager.Registration(_registration))
                {
                    MessageBox.Show(@"Registration Successful");
                }
                else
                {
                    MessageBox.Show(@"Registration Failed");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

           
        }

        private void loginNowButton_Click(object sender, EventArgs e)
        {
            LoginUi loginUi = new LoginUi();
            this.Hide();
            loginUi.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameError.Text = "";
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailError.Text = "";
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordError.Text = "";
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmError.Text = "";
        }
    }
}
