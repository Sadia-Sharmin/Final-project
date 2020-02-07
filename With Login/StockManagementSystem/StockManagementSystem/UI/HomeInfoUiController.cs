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
    public partial class HomeInfoUiController : UserControl
    {
        public HomeInfoUiController()
        {
            InitializeComponent();
            messageLabel.Text = @"Stock Management System";
        }
    }
}
