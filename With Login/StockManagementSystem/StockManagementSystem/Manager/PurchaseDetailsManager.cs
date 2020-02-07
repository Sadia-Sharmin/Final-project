using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.Manager
{
    public class PurchaseDetailsManager
    {
        PurchaseDetailsRepository  _purchaseDetailsRepository=new PurchaseDetailsRepository();

        public bool AddPurchaseDetails(PurchaseDetails purchaseDetails)
        {
            return _purchaseDetailsRepository.AddPurchaseDetails(purchaseDetails);
        }

        public List<PurchaseDetails> GetAllPurchaseDetails()
        {
            return _purchaseDetailsRepository.GetAllPurchaseDetails();
        }

        public int GetLastPurchaseDetailsId()
        {
            return _purchaseDetailsRepository.GetLastPurchaseDetailsId();
        }

        public List<PurchaseDetails> GetPurchaseDetailsByDate(string startDate, string endDate)
        {
            return _purchaseDetailsRepository.GetPurchaseDetailsByDate(startDate, endDate);
        }
    }
}
