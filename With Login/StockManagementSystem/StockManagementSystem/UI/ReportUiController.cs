using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.UI
{
    public partial class ReportUiController : UserControl
    {
        public ReportUiController()
        {
            InitializeComponent();
          
            purchaseActivePanel.Show();
            salesActivePanel.Hide();

            PurchaseReportUiController purchaseReportUiController = new PurchaseReportUiController();
            mainPanel.Controls.Clear();
            purchaseReportUiController.Dock = DockStyle.Fill;
            purchaseReportUiController.BringToFront();
            purchaseReportUiController.Focus();
            mainPanel.Controls.Add(purchaseReportUiController);
        }

        private void purchaseReportButton_Click(object sender, EventArgs e)
        {
            purchaseActivePanel.Show();
            salesActivePanel.Hide();

            PurchaseReportUiController purchaseReportUiController = new PurchaseReportUiController();
            mainPanel.Controls.Clear();
            purchaseReportUiController.Dock = DockStyle.Fill;
            purchaseReportUiController.BringToFront();
            purchaseReportUiController.Focus();
            mainPanel.Controls.Add(purchaseReportUiController);
        }

        private void saleReportButton_Click(object sender, EventArgs e)
        {
            purchaseActivePanel.Hide();
            salesActivePanel.Show();

            SalesReportUiController salesReportUiController = new SalesReportUiController();
            mainPanel.Controls.Clear();
            salesReportUiController.Dock = DockStyle.Fill;
            salesReportUiController.BringToFront();
            salesReportUiController.Focus();
            mainPanel.Controls.Add(salesReportUiController);
        }
    }
}
