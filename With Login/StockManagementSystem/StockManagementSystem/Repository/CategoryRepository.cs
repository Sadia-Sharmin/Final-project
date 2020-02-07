using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using StockManagementSystem.Model;

namespace StockManagementSystem.Repository
{
    public class CategoryRepository
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

    
        public bool AddCategory(Category category)
        {
            bool isAdded = false;

            using (SqlConnection sqlConnection=new SqlConnection(_connectionString))
            {
                string queryString = @"INSERT INTO Categories VALUES('" + category.Code + "','" + category.Name + "')";
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

        public bool UpdateCategory(Category category)
        {
            bool isUpdated = false;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"UPDATE Categories SET Code='" + category.Code + "',Name='" + category.Name + "' WHERE Id="+category.Id+" ";
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

        public List<Category> GetAllCategoryForComboBox()
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection sqlConnection=new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT * FROM Categories";
                SqlCommand sqlCommand=new SqlCommand(queryString,sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                Category category1 = new Category
                {
                    Id = 0,
                    Name = "--Select--"
                };
                categories.Add(category1);
                while (sqlDataReader.Read())
                {
                    Category category=new Category();
                    category.Id =Convert.ToInt32(sqlDataReader["Id"]);
                    category.Code = sqlDataReader["Code"].ToString();
                    category.Name = sqlDataReader["Name"].ToString();
                    categories.Add(category);
                }
            }

            return categories;

        }

        public List<Category> GetAllCategory()
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT * FROM Categories";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

               
                while (sqlDataReader.Read())
                {
                    Category category = new Category();
                    category.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    category.Code = sqlDataReader["Code"].ToString();
                    category.Name = sqlDataReader["Name"].ToString();
                    categories.Add(category);
                }
            }

            return categories;

        }

        public int GetCategoryIdByProductId(int id)
        {
            int categoryId = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"Select c.Id FROM Categories AS c
                                        LEFT JOIN Products AS p ON p.CategoryId=c.Id WHERE p.Id= "+id+" ";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    categoryId = Convert.ToInt32(sqlDataReader["Id"]);
                }
            }

            return categoryId;
        }

        public string GetLastCategoryCode()
        {
            string code = "";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Code FROM Categories ORDER BY Id DESC ";
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

        public bool UniqueName(Category category)
        {
            bool isFound = true;
            string name = "";

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Name FROM Categories WHERE Name='" + category.Name + "' AND Id != " + category.Id + " ";
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

        public List<Category> Search(string name,string code)
        {
           
            List<Category> categories = new List<Category>();
            string queryString = "";

            //Connection
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                //Command 

                if (!String.IsNullOrEmpty(name))
                {
                    queryString = @"SELECT * FROM Categories WHERE Name LIKE '"+'%' + name +'%'+ "' ";
                }
                else
                {
                    queryString = @"SELECT * FROM Categories WHERE Code LIKE'"+'%' + code +'%'+ "' ";
                }
              

                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Category category1 = new Category();                 
                    category1.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    category1.Code = sqlDataReader["Code"].ToString();
                    category1.Name = sqlDataReader["Name"].ToString();

                    categories.Add(category1);

                }

                sqlConnection.Close();
            }

            return categories;

        }

    }
}
