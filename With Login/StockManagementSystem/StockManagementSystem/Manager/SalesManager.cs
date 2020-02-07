using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;


namespace StockManagementSystem.Manager
{
    public class SalesManager
    {
        SalesRepository _salesRepository=new SalesRepository();

        public bool AddSale(List<Sale> sales)
        {
            return _salesRepository.AddSale(sales);
        }
        public string GetLastSaleCode()
        {
            return _salesRepository.GetLastSaleCode();
        }

        public int GetTotalProductById(int id,string saleDate)
        {
            return _salesRepository.GetTotalProductById(id,saleDate);
        }

        public int GetTotalProductByIdAndDate(int id, string date)
        {
            return _salesRepository.GetTotalProductByIdAndDate(id, date);
        }

        public int GetTotalProductByIdAndStartAndEndDate(int id, string startDate, string endDate)
        {
            return _salesRepository.GetTotalProductByIdAndStartAndEndDate(id, startDate, endDate);
        }
    }
}
