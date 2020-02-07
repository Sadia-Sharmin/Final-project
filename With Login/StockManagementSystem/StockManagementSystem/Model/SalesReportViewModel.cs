using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    public class SalesReportViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int SoldQty { get; set; }
        public double CP { get; set; }
        public double SalesPrice { get; set; }
        public double Profit { get; set; }
    }
}
