using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;
using StockManagementSystem.ViewModel;

namespace StockManagementSystem.Manager
{
    public class ProductManager
    {
        ProductRepository _productRepository=new ProductRepository();

        public bool AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }

        //public bool UniqueCode(Product product)
        //{
        //    return _productRepository.UniqueCode(product);
        //}

        public bool UniqueName(Product product)
        {
            return _productRepository.UniqueName(product);
        }
        public List<ProductViewModel> GetAllProduct()
        {
            return _productRepository.GetAllProduct();
        }

        public List<ProductViewModel> GetAllProductByCategoryId(string categoryName)
        {
            return _productRepository.GetAllProductByCategoryId(categoryName);
        }

        public List<Product> GetAllProductForComboBox(int categoryId)
        {
            return _productRepository.GetAllProductForComboBox(categoryId);
        }

        //public string GetProductCodeById(int productId)
        //{
        //    return _productRepository.GetProductCodeById(productId);
        //}

        public string GetLastProductCode()
        {
            return _productRepository.GetLastProductCode();
        }

        public List<ProductViewModel> SearchByNameORCode(string name, string code)
        {
            return _productRepository.SearchByNameOrCode(name, code);
        }

        public int GetReorderLevelById(int id)
        {
            return _productRepository.GetReorderLevelById(id);
        }

        public string GetCodedById(int id)
        {
            return _productRepository.GetCodedById(id);
        }
    }
}
