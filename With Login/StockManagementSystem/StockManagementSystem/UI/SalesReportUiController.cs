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
    public partial class SalesReportUiController : UserControl
    {
        SharedManager _sharedManager = new SharedManager();
        public SalesReportUiController()
        {
            InitializeComponent();
        }

        private void SalesReportUiController_Load(object sender, EventArgs e)
        {
            startDateErrorLabel.Text = "";
            endDateErrorLabel.Text = "";

            SalesReportDataGridView.DataSource = _sharedManager.GetSalesReport();
        }

        private void salesStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
         
            startDateErrorLabel.Text = "";
            int startDate = Convert.ToInt32(salesStartDateTimePicker.Text.Replace("-", ""));
            int endDate = Convert.ToInt32(saleEndDateTimePicker.Text.Replace("-", ""));


            if (startDate > endDate)
            {
                startDateErrorLabel.Text = @"Date must be less than end date";

            }

            endDateErrorLabel.Text = "";
        }

        private void saleEndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateErrorLabel.Text = "";
            int startDate = Convert.ToInt32(salesStartDateTimePicker.Text.Replace("-", ""));
            int endDate = Convert.ToInt32(saleEndDateTimePicker.Text.Replace("-", ""));

            if (endDate < startDate)
            {
                endDateErrorLabel.Text = @"Date must be greater than start date";

            }
            startDateErrorLabel.Text = "";
        }

        private void SalesReportDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SalesReportDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<SalesReportViewModel> model = new List<SalesReportViewModel>();
            model = _sharedManager.SearchSalesReportByDate(salesStartDateTimePicker.Text, saleEndDateTimePicker.Text);
            if (model.Count > 0)
            {
                SalesReportDataGridView.DataSource = model;
            }
            else
            {
                SalesReportDataGridView.DataSource = null;
                MessageBox.Show(@"No Result Found", @"Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
