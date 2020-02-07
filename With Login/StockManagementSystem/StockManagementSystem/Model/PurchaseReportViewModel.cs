using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    public class PurchaseReportViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int AvailableQty { get; set; }
        public double CP { get; set; }
        public double MRP { get; set; }
        public double Profit { get; set; }

    }
}
