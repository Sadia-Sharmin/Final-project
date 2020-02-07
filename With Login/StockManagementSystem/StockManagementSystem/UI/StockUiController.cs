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
    public partial class StockUiController : UserControl
    {
        CategoryManager _categoryManager = new CategoryManager();
        ProductManager _productManager = new ProductManager();
        SharedManager  _sharedManager=new SharedManager();
        public StockUiController()
        {
            InitializeComponent();
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.DataSource = _categoryManager.GetAllCategoryForComboBox();

            //int categoryId = Convert.ToInt32(categoryComboBox.SelectedValue);

            //productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //productComboBox.DataSource = _productManager.GetAllProductForComboBox(categoryId);

        }

        private void StockUiController_Load(object sender, EventArgs e)
        {
            categoryComboboxerrorLabel.Text = "";
            productComboBoxErrorLabel.Text = "";

            startDateErrorLabel.Text = "";
            endDateErrorLabel.Text = "";

            stockDataGridView.DataSource = _sharedManager.GetStockReport(startDateTimePicker.Text,endDateTimePicker.Text);


        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryComboboxerrorLabel.Text = "";
            int categoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
           

            if (categoryId>0)
            {
                stockDataGridView.DataSource = null;
                List<Stock> stocks = new List<Stock>();

                stocks = _sharedManager.SearchStockReportByDate(startDateTimePicker.Text, endDateTimePicker.Text, categoryId, 0);

                if (stocks.Count != 0)
                {
                    stockDataGridView.DataSource = stocks;
                }
                else
                {
                    stockDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
           


            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBox.DataSource = _productManager.GetAllProductForComboBox(categoryId);

          
            
           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            //if (Convert.ToInt32(categoryComboBox.SelectedValue) == 0)
            //{
            //    categoryComboboxerrorLabel.Text = @"Select a category !";
            //    categoryComboBox.Focus();
            //    return;
            //}

            //if (Convert.ToInt32(productComboBox.SelectedValue) == 0)
            //{
            //    productComboBoxErrorLabel.Text = @"Select a product";
            //    productComboBox.Focus();
            //    return;
            //}

            List<Stock> stocks = new List<Stock>();

            int categoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            int proId = Convert.ToInt32(productComboBox.SelectedValue);

            stocks = _sharedManager.SearchStockReportByDate(startDateTimePicker.Text, endDateTimePicker.Text, categoryId, proId);
            if (stocks.Count > 0)
            {
                stockDataGridView.DataSource = stocks;
            }
            else
            {
                stockDataGridView.DataSource = null;
                MessageBox.Show(@"No Result Found", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productComboBoxErrorLabel.Text = "";
          
            int proId = Convert.ToInt32(productComboBox.SelectedValue);

            if (proId > 0)
            {
                stockDataGridView.DataSource = null;
                List<Stock> stocks = new List<Stock>();
                stocks = _sharedManager.SearchStockReportByDate(startDateTimePicker.Text, endDateTimePicker.Text, 0, proId);
                if (stocks.Count != 0)
                {
                    stockDataGridView.DataSource = stocks;
                }
                else
                {
                    stockDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = true;
            startDateErrorLabel.Text = "";
            int startDate = Convert.ToInt32(startDateTimePicker.Text.Replace("-", ""));
            int endDate = Convert.ToInt32(endDateTimePicker.Text.Replace("-", ""));


            if (startDate > endDate)
            {
                startDateErrorLabel.Text = @"Date must be less than end date";
                searchButton.Enabled = false;
            }

            endDateErrorLabel.Text = "";
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = true;
            endDateErrorLabel.Text = "";
            int startDate = Convert.ToInt32(startDateTimePicker.Text.Replace("-", ""));
            int endDate = Convert.ToInt32(endDateTimePicker.Text.Replace("-", ""));

            if (endDate < startDate)
            {
                endDateErrorLabel.Text = @"Date must be greater than start date";
                searchButton.Enabled = false;
            }
            startDateErrorLabel.Text = "";
        }

        private void purchaseDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            stockDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
