using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.Manager
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository=new CategoryRepository();

       
        public bool AddCategory(Category category)
        {
            return _categoryRepository.AddCategory(category);
        }

        public bool UpdateCategory(Category category)
        {
            return _categoryRepository.UpdateCategory(category);
        }

        public List<Category> GetAllCategory()
        {
            return _categoryRepository.GetAllCategory();
        }

        public List<Category> GetAllCategoryForComboBox()
        {
            return _categoryRepository.GetAllCategoryForComboBox();
        }

        public int GetCategoryIdByProductId(int id)
        {
            return _categoryRepository.GetCategoryIdByProductId(id);
        }


        public string GetLastCategoryCode()
        {
            return _categoryRepository.GetLastCategoryCode();
        }

        public bool UniqueName(Category category)
        {
            return _categoryRepository.UniqueName(category);
        }

        public List<Category> Search(string name, string code)
        {

            return _categoryRepository.Search(name,code);
        }

    }
}
