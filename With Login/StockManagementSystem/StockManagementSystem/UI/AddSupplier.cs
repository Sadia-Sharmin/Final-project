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
using System.Text.RegularExpressions;

namespace StockManagementSystem.UI
{
    public partial class AddSupplier : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        Supplier _supplier = new Supplier();
        private SupplierUiController supplierUiController;
        public int supplierId;
        string pattern;

        public AddSupplier(SupplierUiController supplierUiController2)
        {
            supplierUiController = supplierUiController2;
            InitializeComponent();
            GenerateSupplierCode();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult;
            dialogResult = MessageBox.Show(@"Are you sure, you want to exit?", @"Message Box", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
           
            ClearAllErrorLabel();
           
        }
        private void GenerateSupplierCode()
        {
            string lastsupplierCode = _supplierManager.GetLastSupplierCode();

            if (lastsupplierCode == "")
            {
                lastsupplierCode = "0001";
            }
            else
            {
                int number = int.Parse(lastsupplierCode);
                lastsupplierCode = (++number).ToString("D" + lastsupplierCode.Length);

            }

            codeTextBox.Text = lastsupplierCode;
        }

        public void ClearAllTextBox()
        {
            codeTextBox.Text = "";
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            emailTextBox.Text = "";
            contactTextBox.Text = "";
            contactPersonTextBox.Text = "";
        }

        public void ClearAllErrorLabel()
        {
            nameErrorLabel.Text = "";
            emailErrorLabel.Text = "";
            contactErrorLabel.Text = "";
            contactPersonErrorLabel.Text = "";
            addressErrorLabel.Text = "";
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameErrorLabel.Text = "";
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (Regex.IsMatch(emailTextBox.Text, pattern))
            {
                emailErrorLabel.Text = "";
            }
            else
            {
                emailErrorLabel.Text = @"Enter Valid Email!!";
                emailErrorLabel.ForeColor = Color.Red;
                return;
            }
        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {
            contactErrorLabel.Text = "";
        }

        private void contactPersonTextBox_TextChanged(object sender, EventArgs e)
        {
            contactPersonErrorLabel.Text = "";
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            addressErrorLabel.Text = "";
        }

        private void saveOrUpdateButton_Click(object sender, EventArgs e)
        {
            _supplier.Id = supplierId;
            _supplier.Code = codeTextBox.Text;
            _supplier.Name = nameTextBox.Text;
            _supplier.Address = addressTextBox.Text;
            _supplier.Email = emailTextBox.Text;
            _supplier.Contact = contactTextBox.Text;
            // _supplier.LoyaltyPoint = Convert.ToDouble(loyaltyPointTextBox.Text);


            if (String.IsNullOrEmpty(_supplier.Name))
            {
                nameErrorLabel.ForeColor = Color.Red;
                nameErrorLabel.Text = @"Name is required";
                nameTextBox.Focus();
                return;
            }

            if (_supplierManager.UniqueEmail(_supplier))
            {
                emailErrorLabel.ForeColor = Color.Red;
                emailErrorLabel.Text = @"Email is already exist !";
                emailTextBox.Focus();
                return;
            }
            if (String.IsNullOrEmpty(_supplier.Email))
            {
                emailErrorLabel.ForeColor = Color.Red;
                emailErrorLabel.Text = @"Email is required !";
                emailTextBox.Focus();
                return;
            }

            if (_supplierManager.UniqueContact(_supplier))
            {
                contactErrorLabel.ForeColor = Color.Red;
                contactErrorLabel.Text = @"Contact is already exist !";
                contactTextBox.Focus();
                return;
            }
            if (!String.IsNullOrEmpty(_supplier.Contact) && _supplier.Contact.Length != 11)
            {
                contactErrorLabel.ForeColor = Color.Red;
                contactErrorLabel.Text = @"Contact is 11 character length required !";
                contactTextBox.Focus();
                return;
            }
            if (String.IsNullOrEmpty(_supplier.Contact))
            {
                contactErrorLabel.ForeColor = Color.Red;
                contactErrorLabel.Text = @"Contact is required !";
                contactTextBox.Focus();
                return;
            }

            if (String.IsNullOrEmpty(contactPersonTextBox.Text))
            {
                contactPersonErrorLabel.ForeColor = Color.Red;
                contactPersonErrorLabel.Text = @"Contact person is required !";
                contactPersonErrorLabel.Focus();
                return;
            }
           

            if (String.IsNullOrEmpty(_supplier.Address))
            {
                addressErrorLabel.ForeColor = Color.Red;
                addressErrorLabel.Text = @"Address is required !";
                addressTextBox.Focus();
                return;
            }

            _supplier.ContactPerson = contactPersonTextBox.Text;

            if (saveOrUpdateButton.Text == @"Save")
            {
                if (_supplierManager.AddSupplier(_supplier))
                {
                    supplierUiController.ShowAllSupplier();
                    MessageBox.Show(@"Saved Successfully");
                    // customerDataGridView.DataSource = _supplierManager.GetAllCustomer();

                    GenerateSupplierCode();
                }
                else
                {
                    MessageBox.Show(@"Save Failed");
                }
            }
            else
            {
                if (_supplierManager.UpdateSupplier(_supplier))
                {
                    supplierUiController.ShowAllSupplier();
                    MessageBox.Show(@"Updated Successfully");
                    //customerDataGridView.DataSource = _supplierManager.GetAllCustomer();

                    saveOrUpdateButton.Text = "Save";

                    //Close();
                }
                else
                {
                    MessageBox.Show(@"Update Failed");
                }

            }

            ClearAllTextBox();
            ClearAllErrorLabel();
            GenerateSupplierCode();
        }
    }
}

