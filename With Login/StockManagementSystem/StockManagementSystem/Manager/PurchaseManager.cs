using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.Manager
{
    public class PurchaseManager
    {
        PurchaseRepository _purchaseRepository = new PurchaseRepository();

        public Purchase GetLastPurchasesProductInfoById(int id)
        {
            return _purchaseRepository.GetLastPurchasesProductInfoById(id);
        }

        public bool UniquePurchaseCode(PurchaseDetails purchaseDetails)
        {
            return _purchaseRepository.UniquePurchaseCode(purchaseDetails);
        }

        public bool AddPurchase(List<Purchase> purchases)
        {
            return _purchaseRepository.AddPurchase(purchases);
        }

        public string GetLastPurchaseCode()
        {
            return _purchaseRepository.GetLastPurchaseCode();
        }

        public int GetTotalProductById(int id,string purchaseDate)
        {
            return _purchaseRepository.GetTotalProductById(id,purchaseDate);
        }

        public int GetTotalProductByIdAndDate(int id, string date)
        {
            return _purchaseRepository.GetTotalProductByIdAndDate(id, date);
        }

        public int GetTotalProductByIdAndStartAndEndDate(int id, string startDate, string endDate)
        {
            return _purchaseRepository.GetTotalProductByIdAndStartAndEndDate(id, startDate, endDate);
        }

        public List<Purchase> GetProductByPurchaseDetailsId(int id)
        {
            return _purchaseRepository.GetProductByPurchaseDetailsId(id);
        }
    }
}
