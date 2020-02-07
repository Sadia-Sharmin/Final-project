using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    public class Product
    {
        public int Id { set; get; }
        public int CategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int RecorderLevel { get; set; }
        public string Description { get; set; }

    }
}
