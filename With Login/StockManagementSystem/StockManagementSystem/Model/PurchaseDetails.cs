using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    public class PurchaseDetails
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public string Code { get; set; }
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public string Date { get; set; }

    }
}
