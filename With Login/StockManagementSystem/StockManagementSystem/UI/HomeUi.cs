using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.UI
{
    public partial class HomeUi : Form
    {
        CategoryUiController categoryUiController = new CategoryUiController();
        ProductUiController productUiController = new ProductUiController();
        SupplierUiController supplierUiController = new SupplierUiController();
        SalesUiController salesUiController = new SalesUiController();
        PurchaseUiController purchaseUiController = new PurchaseUiController();
        StockUiController stockUiController = new StockUiController();
        ReportUiController reportUiController = new ReportUiController();

        public HomeUi()
        {
            InitializeComponent();
            activePanel.Height = homeButton.Height;
            activePanel.Top = homeButton.Top;

            HomeInfoUiController homeInfoUiController = new HomeInfoUiController();
            mainPanel.Controls.Clear();
            homeInfoUiController.Dock = DockStyle.Fill;
            homeInfoUiController.BringToFront();
            homeInfoUiController.Focus();
            mainPanel.Controls.Add(homeInfoUiController);

           
            // timeLabel.Text= DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ClearAllUserController()
        {
            categoryUiController.Controls.Clear();
            productUiController.Controls.Clear();
            supplierUiController.Controls.Clear();
            salesUiController.Controls.Clear();
            purchaseUiController.Controls.Clear();
            stockUiController.Controls.Clear();
            reportUiController.Controls.Clear();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(@"Are you sure, you want to exit?", @"Message Box", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        #region Drag

        public const int WmNclbuttondown = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclbuttondown, HT_CAPTION, 0);
            }
        }

        #endregion


        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            ClearAllUserController();
            activePanel.Height = homeButton.Height;
            activePanel.Top = homeButton.Top;

            HomeInfoUiController homeInfoUiController = new HomeInfoUiController();
            mainPanel.Controls.Clear();
            homeInfoUiController.Dock = DockStyle.Fill;
            homeInfoUiController.BringToFront();
            homeInfoUiController.Focus();
            mainPanel.Controls.Add(homeInfoUiController);
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            ClearAllUserController();

            activePanel.Height = categoryButton.Height;
            activePanel.Top = categoryButton.Top;

            categoryUiController = new CategoryUiController();
            mainPanel.Controls.Clear();
            categoryUiController.Dock = DockStyle.Fill;
            categoryUiController.BringToFront();
            categoryUiController.Focus();
            mainPanel.Controls.Add(categoryUiController);
           
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            ClearAllUserController();

            activePanel.Height = productButton.Height;
            activePanel.Top = productButton.Top;

            productUiController = new ProductUiController();
            mainPanel.Controls.Clear();
            productUiController.Dock = DockStyle.Fill;
            productUiController.BringToFront();
            productUiController.Focus();
            mainPanel.Controls.Add(productUiController);

        }

        

        private void supplierButton_Click(object sender, EventArgs e)
        {
            ClearAllUserController();

            activePanel.Height = supplierButton.Height;
            activePanel.Top = supplierButton.Top;

            supplierUiController = new SupplierUiController();
            mainPanel.Controls.Clear();
            supplierUiController.Dock = DockStyle.Fill;
            supplierUiController.BringToFront();
            supplierUiController.Focus();
            mainPanel.Controls.Add(supplierUiController);

        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            ClearAllUserController();

            activePanel.Height = purchaseButton.Height;
            activePanel.Top = purchaseButton.Top;

           
            purchaseUiController = new PurchaseUiController();
            mainPanel.Controls.Clear();
            purchaseUiController.Dock = DockStyle.Fill;
            purchaseUiController.BringToFront();
            purchaseUiController.Focus();
            mainPanel.Controls.Add(purchaseUiController);

        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            ClearAllUserController();

            activePanel.Height = stockButton.Height;
            activePanel.Top = stockButton.Top;


            stockUiController = new StockUiController();
            mainPanel.Controls.Clear();
            stockUiController.Dock = DockStyle.Fill;
            stockUiController.BringToFront();
            stockUiController.Focus();
            mainPanel.Controls.Add(stockUiController);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ClearAllUserController();

            activePanel.Height = reportButton.Height;
            activePanel.Top = reportButton.Top;


            reportUiController = new ReportUiController();
            mainPanel.Controls.Clear();
            reportUiController.Dock = DockStyle.Fill;
            reportUiController.BringToFront();
            reportUiController.Focus();
            mainPanel.Controls.Add(reportUiController);

        }

        private void saleButton_Click(object sender, EventArgs e)
        {

            ClearAllUserController();

            activePanel.Height = saleButton.Height;
            activePanel.Top = saleButton.Top;


            salesUiController = new SalesUiController();
            mainPanel.Controls.Clear();
            salesUiController.Dock = DockStyle.Fill;
            salesUiController.BringToFront();
            salesUiController.Focus();
            mainPanel.Controls.Add(salesUiController);
        }
    }
}
