using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Manager;
using StockManagementSystem.Model;

namespace StockManagementSystem.UI
{
    public partial class SupplierUiController : UserControl
    {
        SupplierManager _supplierManager = new SupplierManager();
        Supplier _supplier = new Supplier();
        public SupplierUiController()
        {
            InitializeComponent();
        }

        private void SupplierUiController_Load(object sender, EventArgs e)
        {
            ShowAllSupplier();
            searchTextBoxErrorLabel.Text = "";
            nameRadioButton.Checked = true;
        }
        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier(this);
            if (showDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                addSupplier.supplierId = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells[1].Value);
                addSupplier.codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                addSupplier.nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                addSupplier.addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                addSupplier.emailTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                addSupplier.contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                addSupplier.contactPersonTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                addSupplier.saveOrUpdateButton.Text = "Update";

                addSupplier.Show();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchTextBox.Text))
            {
                searchTextBoxErrorLabel.ForeColor = Color.Red;
                searchTextBoxErrorLabel.Text = @"Search value required !";
                searchTextBoxErrorLabel.Focus();
                return;
            }

            List<Supplier> suppliers=new List<Supplier>();
            if (nameRadioButton.Checked==true)
            {
                suppliers = _supplierManager.SearchSupplier(searchTextBox.Text, "", "");
                if (suppliers.Count!=0)
                {
                    showDataGridView.DataSource = suppliers;
                }
                else
                {
                    showDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (emailRadioButton.Checked == true)
            {
                suppliers = _supplierManager.SearchSupplier("", searchTextBox.Text, "");
                if (suppliers.Count != 0)
                {
                    showDataGridView.DataSource = suppliers;
                }
                else
                {
                    showDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (contactRadioButton.Checked == true)
            {
                suppliers = _supplierManager.SearchSupplier("", "", searchTextBox.Text);
                if (suppliers.Count != 0)
                {
                    showDataGridView.DataSource = suppliers;
                }
                else
                {
                    showDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void ShowAllSupplier()
        {
            showDataGridView.DataSource = _supplierManager.ShowSupplierInfo();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void addSupplierButton_Click(object sender, EventArgs e)
        {
          AddSupplier addSupplier=new AddSupplier(this);
          addSupplier.Show();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowAllSupplier();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchTextBoxErrorLabel.Text = "";
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(searchTextBox.Text))
            {
               ShowAllSupplier();
                return;
            }

            List<Supplier> suppliers = new List<Supplier>();
            if (nameRadioButton.Checked == true)
            {
                suppliers = _supplierManager.SearchSupplier(searchTextBox.Text, "", "");
                if (suppliers.Count != 0)
                {
                    showDataGridView.DataSource = suppliers;
                }
                else
                {
                    showDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchTextBox.Text = "";
                    ShowAllSupplier();
                }
            }
            if (emailRadioButton.Checked == true)
            {
                suppliers = _supplierManager.SearchSupplier("", searchTextBox.Text, "");
                if (suppliers.Count != 0)
                {
                    showDataGridView.DataSource = suppliers;
                }
                else
                {
                    showDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchTextBox.Text = "";
                    ShowAllSupplier();
                }
            }
            if (contactRadioButton.Checked == true)
            {
                suppliers = _supplierManager.SearchSupplier("", "", searchTextBox.Text);
                if (suppliers.Count != 0)
                {
                    showDataGridView.DataSource = suppliers;
                }
                else
                {
                    showDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchTextBox.Text = "";
                    ShowAllSupplier();
                }
            }
        }
    }
}
