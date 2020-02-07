using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using StockManagementSystem.Repository;
using StockManagementSystem.Model;

namespace StockManagementSystem.Manager
{
   public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
        //Save
        public bool AddSupplier(Supplier supplier)
        {
            return _supplierRepository.AddSupplier(supplier);
        }
        public bool UpdateSupplier(Supplier supplier)
        {
            return _supplierRepository.UpdateSupplier(supplier);
        }
        public List<Supplier> ShowSupplierInfo()
        {
            return _supplierRepository.ShowSupplierInfo();
        }
        public List<Supplier> SearchSupplier(string name,string email,string contact)
        {
            return _supplierRepository.SearchSupplier(name,email,contact);
        }
        public bool UniqueContact(Supplier supplier)
        {
            return _supplierRepository.UniqueContact(supplier);
        }
        public bool UniqueEmail(Supplier supplier)
        {
            return _supplierRepository.UniqueEmail(supplier);
        }
        public string GetLastSupplierCode()
        {
            return _supplierRepository.GetLastSupplierCode();
        }
        public List<Supplier> GetAllSupplierForComboBox()
        {
            return _supplierRepository.GetAllSupplierForComboBox();
        }

    }
}
