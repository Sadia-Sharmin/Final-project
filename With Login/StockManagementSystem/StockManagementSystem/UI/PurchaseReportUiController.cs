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
    public partial class PurchaseReportUiController : UserControl
    {
        SharedManager _sharedManager=new SharedManager();
        public PurchaseReportUiController()
        {
            InitializeComponent();
        }

        private void PurchaseReportUiController_Load(object sender, EventArgs e)
        {
            startDateErrorLabel.Text = "";
            endDateErrorLabel.Text = "";
            purchaseReportDataGridView.DataSource = _sharedManager.GetPurchaseReport(purchaseStartDateTimePicker.Text, purchaseEndDateTimePicker.Text);
        }

        private void purchaseReportDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            purchaseReportDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<PurchaseReportViewModel> model=new List<PurchaseReportViewModel>();
            model = _sharedManager.SearchPurchaseReportByDate(purchaseStartDateTimePicker.Text,purchaseEndDateTimePicker.Text);
            if (model.Count>0)
            {
                purchaseReportDataGridView.DataSource = model;
            }
            else
            {
                purchaseReportDataGridView.DataSource = null;
                MessageBox.Show(@"No Result Found", @"Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void purchaseStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startDateErrorLabel.Text = "";
            int startDate = Convert.ToInt32(purchaseStartDateTimePicker.Text.Replace("-",""));
            int endDate = Convert.ToInt32(purchaseEndDateTimePicker.Text.Replace("-", ""));


            if (startDate>endDate)
            {
                startDateErrorLabel.Text = @"Date must be less than end date";
               
            }

            endDateErrorLabel.Text = "";

        }

        private void purchaseEndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateErrorLabel.Text = "";
            int startDate = Convert.ToInt32(purchaseStartDateTimePicker.Text.Replace("-", ""));
            int endDate = Convert.ToInt32(purchaseEndDateTimePicker.Text.Replace("-", ""));

            if (endDate<startDate)
            {
                endDateErrorLabel.Text = @"Date must be greater than start date";
               
            }
            startDateErrorLabel.Text = "";
        }
    }
}
