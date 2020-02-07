using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Manager;
using StockManagementSystem.Model;

namespace StockManagementSystem.UI
{
    public partial class PurchaseUiController : UserControl
    {
        PurchaseDetailsManager _purchaseDetailsManager=new PurchaseDetailsManager();
        PurchaseManager _purchaseManager=new PurchaseManager();

        public PurchaseUiController()
        {
            InitializeComponent();
        }
        private void PurchaseUiController_Load(object sender, EventArgs e)
        {
            ShowAllPurchase();
        }

        private void addPurchaseButton_Click(object sender, EventArgs e)
        {
            AddPurchaseUi addPurchaseUi=new AddPurchaseUi();
            addPurchaseUi.Show();
        }

        private void ShowAllPurchase()
        {
            purchaseStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            purchaseStartDateTimePicker.Text = DateTime.Today.ToString();
            purchaseEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
            purchaseEndDateTimePicker.Text = DateTime.Today.ToString();
            startDateErrorLabel.Text = "";
            endDateErrorLabel.Text = "";
            purchaseDataGridView.DataSource = _purchaseDetailsManager.GetAllPurchaseDetails();
        }

        private void purchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (purchaseDataGridView.Columns[e.ColumnIndex].Name == "Details")
            {
                //MessageBox.Show("details");
                PurchaseDetailsUi purchaseDetails = new PurchaseDetailsUi();

                int purchaseDetailsId = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[1].Value);
               // int supplierId = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[4].Value);
               // MessageBox.Show(purchaseDetailsId + "  " + supplierId);

               purchaseDetails.purchaseDetailsDataGridView.DataSource =
                   _purchaseManager.GetProductByPurchaseDetailsId(purchaseDetailsId);
                purchaseDetails.Show();
            }

            
        }

        private void purchaseDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.purchaseDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }
        private void purchaseStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startDateErrorLabel.Text = "";
            int startDate = Convert.ToInt32(purchaseStartDateTimePicker.Text.Replace("-", ""));
            int endDate = Convert.ToInt32(purchaseEndDateTimePicker.Text.Replace("-", ""));


            if (startDate > endDate)
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

            if (endDate < startDate)
            {
                endDateErrorLabel.Text = @"Date must be greater than start date";

            }
            startDateErrorLabel.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<PurchaseDetails> model = new List<PurchaseDetails>();
            model = _purchaseDetailsManager.GetPurchaseDetailsByDate(purchaseStartDateTimePicker.Text, purchaseEndDateTimePicker.Text);
            if (model.Count > 0)
            {
                purchaseDataGridView.DataSource = model;
            }
            else
            {
                purchaseDataGridView.DataSource = null;
                MessageBox.Show(@"No Result Found", @"Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ShowAllPurchase();
        }
    }
}
