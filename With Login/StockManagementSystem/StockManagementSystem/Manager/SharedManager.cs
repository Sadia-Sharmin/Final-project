using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.Manager
{
    public class SharedManager
    {
        SharedRepository _sharedRepository=new SharedRepository();
        public List<PurchaseReportViewModel> GetPurchaseReport(string startDate, string endDate)
        {
            return _sharedRepository.GetPurchaseReport(startDate, endDate);
        }

        public List<PurchaseReportViewModel> SearchPurchaseReportByDate(string startDate,string endDate)
        {
            return _sharedRepository.SearchPurchaseReportByDate(startDate,endDate);
        }


        public List<SalesReportViewModel> GetSalesReport()
        {
            return _sharedRepository.GetSalesReport();
        }

        public List<SalesReportViewModel> SearchSalesReportByDate(string startDate, string endDate)
        {
            return _sharedRepository.SearchSalesReportByDate(startDate, endDate);
        }


        public List<Stock> GetStockReport(string startDate, string endDate)
        {
            return _sharedRepository.GetStockReport(startDate,endDate);
        }

        public List<Stock> SearchStockReportByDate(string startDate, string endDate, int categoryId, int productId)
        {
            return _sharedRepository.SearchStockReportByDate(startDate, endDate,categoryId,productId);
        }

    }
}
