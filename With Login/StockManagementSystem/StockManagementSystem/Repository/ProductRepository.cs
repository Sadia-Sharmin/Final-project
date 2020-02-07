using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using System.Configuration;
using System.Data.SqlClient;
using StockManagementSystem.ViewModel;

namespace StockManagementSystem.Repository
{
    class ProductRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public bool AddProduct(Product product)
        {
            bool isAdded = false;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"INSERT INTO Products VALUES('" + product.Code + "','" + product.Name + "',"+ product .CategoryId+ ","+product.RecorderLevel+",'"+product.Description+"')";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                //close connection
                sqlConnection.Close();

                if (isExecuted > 0)
                {
                    isAdded = true;
                }
            }

            return isAdded;
        }

        public bool UpdateProduct(Product product)
        {
            bool isUpdated = false;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"UPDATE Products SET Code='" + product.Code + "',Name='" + product.Name + "',CategoryId=" + product.CategoryId + ",ReorderLevel=" + product.RecorderLevel + ",Description='" + product.Description + "' WHERE Id="+product.Id+" ";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                //close connection
                sqlConnection.Close();

                if (isExecuted > 0)
                {
                    isUpdated = true;
                }
            }

            return isUpdated;
        }

        public bool UniqueName(Product product)
        {
            bool isFound = true;
            string name = "";

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Name FROM Products WHERE Name='" + product.Name + "' AND Id != " + product.Id + " ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                     name = sqlDataReader["Name"].ToString();

                }

                //close connection
                sqlConnection.Close();

                if (String.IsNullOrEmpty(name))
                {
                    isFound = false;
                }
            }

            return isFound;
        }
        public List<ProductViewModel> GetAllProduct()
        {
            List<ProductViewModel> _productViewModels = new List<ProductViewModel>();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT * FROM ProductInformation";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ProductViewModel productViewModel = new ProductViewModel();

                    productViewModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    productViewModel.Name = sqlDataReader["Name"].ToString();
                    productViewModel.Code = sqlDataReader["Code"].ToString();
                    productViewModel.Category = sqlDataReader["Category"].ToString();
                    productViewModel.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                    productViewModel.Description = sqlDataReader["Description"].ToString();

                    _productViewModels.Add(productViewModel);
                }

                //close connection
                sqlConnection.Close();

                return _productViewModels;
            }
        }

        public List<Product> GetAllProductForComboBox(int categoryId)
        {
            List<Product> products = new List<Product>();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Id,Name FROM Products WHERE CategoryId="+categoryId+" ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                Product product1 = new Product
                {
                    Id = 0,Name = "--Select--"
                };
                products.Add(product1);

                while (sqlDataReader.Read())
                {
                    Product product = new Product();

                    product.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    product.Name = sqlDataReader["Name"].ToString();
                    products.Add(product);
                }

                //close connection
                sqlConnection.Close();

                return products;
            }
        }

        //public string GetProductCodeById(int productId)
        //{
        //    string code = "";
        //    using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
        //    {
        //        string queryString = @"SELECT * FROM Products WHERE Id=" + productId + " ";
        //        SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

        //        //open connection
        //        sqlConnection.Open();

        //        SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
        //        while (sqlDataReader.Read())
        //        {
        //            code= sqlDataReader["Code"].ToString();


        //        }

        //        //close connection
        //        sqlConnection.Close();

        //    }

        //    return code;
        //}

        public string GetLastProductCode()
        {
            string code = "";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Code FROM Products ORDER BY Id DESC ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    code = sqlDataReader["Code"].ToString();
                    break;
                }

                //close connection
                sqlConnection.Close();

            }

            return code;
        }

        public List<ProductViewModel> GetAllProductByCategoryId(string categoryName)
        {
            List<ProductViewModel> _productViewModels = new List<ProductViewModel>();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT * FROM ProductInformation WHERE Category='"+ categoryName + "' ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ProductViewModel productViewModel = new ProductViewModel();

                    productViewModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    productViewModel.Name = sqlDataReader["Name"].ToString();
                    productViewModel.Code = sqlDataReader["Code"].ToString();
                    productViewModel.Category = sqlDataReader["Category"].ToString();
                    productViewModel.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                    productViewModel.Description = sqlDataReader["Description"].ToString();

                    _productViewModels.Add(productViewModel);
                }

                //close connection
                sqlConnection.Close();

                return _productViewModels;
            }
        }


        public List<ProductViewModel> SearchByNameOrCode(string name, string code)
        {
            List<ProductViewModel> _productViewModels = new List<ProductViewModel>();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = "";
                if (!String.IsNullOrEmpty(name))
                {
                    queryString = @"SELECT * FROM ProductInformation WHERE Name LIKE '" + '%' + name + '%' + "' ";
                }
                if (!String.IsNullOrEmpty(code))
                {
                    queryString = @"SELECT * FROM ProductInformation WHERE Code LIKE '" + '%' + code + '%' + "' ";
                }

                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ProductViewModel productViewModel = new ProductViewModel();

                    productViewModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    productViewModel.Name = sqlDataReader["Name"].ToString();
                    productViewModel.Code = sqlDataReader["Code"].ToString();
                    productViewModel.Category = sqlDataReader["Category"].ToString();
                    productViewModel.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                    productViewModel.Description = sqlDataReader["Description"].ToString();

                    _productViewModels.Add(productViewModel);
                }

                //close connection
                sqlConnection.Close();

                return _productViewModels;
            }
        }

        
        public int GetReorderLevelById(int id)
        {
            int reorderLevel = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT ReorderLevel FROM Products WHERE Id=" + id + " ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    reorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                    break;
                }

                //close connection
                sqlConnection.Close();

            }

            return reorderLevel;
        }

        public string GetCodedById(int id)
        {
            string Code = "";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Code FROM Products WHERE Id=" + id + " ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Code = sqlDataReader["Code"].ToString();
                    break;
                }

                //close connection
                sqlConnection.Close();

            }

            return Code;
        }
    }
}
