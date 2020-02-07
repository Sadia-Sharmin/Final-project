 using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
 using System.Windows.Forms;
 using StockManagementSystem.Model;

namespace StockManagementSystem.Repository
{
    public class SalesRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public bool AddSale(List<Sale> sales)
        {

            bool isAdded = false;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            { //open connection
                sqlConnection.Open();
                foreach (var sale in sales)
                {
                    string queryString = @"INSERT INTO Sales VALUES('" + sale.CustomerName + "','"+sale.MobileNo+"'," + sale.ProductId + ",'" + sale.Code + "','" + sale.Date + "'," + sale.Quantity + "," + sale.MRP + "," + sale.TotalMRP + ");";
                    SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);


                    int isExecuted = sqlCommand.ExecuteNonQuery();


                    if (isExecuted > 0)
                    {
                        isAdded = true;
                    }
                }
                //close connection
                sqlConnection.Close();

            }

            return isAdded;
        }

        public string GetLastSaleCode()
        {
            string code = "";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Code FROM Sales ORDER BY Id DESC ";
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

        public int GetTotalProductById(int id,string saleDate)
        {
            int totalQuantity = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT SUM(s.Quantity) AS TotalQuantity FROM Sales as s where s.ProductId=" + id + "  AND Date<='"+saleDate+"' Group by s.ProductId ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    //MessageBox.Show(sqlDataReader["TotalQuantity"].ToString());
                    totalQuantity = Convert.ToInt32(sqlDataReader["TotalQuantity"]);
                    break;
                }

                //close connection
                sqlConnection.Close();

            }

            return totalQuantity;

        }

        public int GetTotalProductByIdAndDate(int id, string date)
        {
            int totalQuantity = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT coalesce(Sum(Quantity),0) AS TotalQuantity FROM Sales WHERE ProductId=" + id + " AND Date< '" + date + "' GROUP BY ProductId ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        totalQuantity = Convert.ToInt32(sqlDataReader["TotalQuantity"]);
                        break;
                    }
                }


                //close connection
                sqlConnection.Close();

            }

            return totalQuantity;
        }

        public int GetTotalProductByIdAndStartAndEndDate(int id, string startDate, string endDate)
        {
            int totalQuantity = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT coalesce(Sum(Quantity),0) AS TotalQuantity FROM Sales WHERE ProductId=" + id + " AND Date BETWEEN '" + startDate + "' AND '" + endDate + "' GROUP BY ProductId ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        totalQuantity = Convert.ToInt32(sqlDataReader["TotalQuantity"]);
                        break;
                    }
                }


                //close connection
                sqlConnection.Close();

            }

            return totalQuantity;
        }

    }
}
