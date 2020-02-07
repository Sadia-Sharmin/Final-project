using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    public class Sale
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Code { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }
        public int ProductId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double MRP { get; set; }
        public double TotalMRP { get; set; }
    }
}
