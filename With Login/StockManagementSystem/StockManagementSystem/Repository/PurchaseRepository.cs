using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using System.Data.SqlClient;
using System.Data;
using StockManagementSystem.Manager;

namespace StockManagementSystem.Repository
{
    public class PurchaseRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        PurchaseDetailsManager _purchaseDetailsManager = new PurchaseDetailsManager();

        public Purchase GetLastPurchasesProductInfoById(int id)
        {
            Purchase purchase = new Purchase();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT * FROM Purchases WHERE ProductId=" + id+ " ORDER BY Id ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                
                while (sqlDataReader.Read())
                {

                    purchase.Id =Convert.ToInt32(sqlDataReader["id"]);
                    //purchase.Date = sqlDataReader["Date"].ToString();
                    //purchase.InvoiceNo = sqlDataReader["InvoiceNo"].ToString();
                    //purchase.SupplierId = Convert.ToInt32(sqlDataReader["SupplierId"]);
                    purchase.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                    purchase.ManufacturedDate = sqlDataReader["ManufacturedDate"].ToString();
                    purchase.ExpireDate = sqlDataReader["ExpireDate"].ToString();
                    purchase.Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    purchase.UnitPrice = Convert.ToDouble( sqlDataReader["UnitPrice"]);
                    purchase.TotalPrice = Convert.ToDouble( sqlDataReader["TotalPrice"]);
                    purchase.MRP = Convert.ToDouble(sqlDataReader["MRP"]);
                    purchase.Remarks = sqlDataReader["Remarks"].ToString();

                }

                //close connection
                sqlConnection.Close();
            }

            return purchase;
        }

        public bool UniquePurchaseCode(PurchaseDetails purchaseDetails)
        {
            bool exists = false;

            //Connection

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {

                //Command 
                string commandString = @"SELECT InvoiceNo FROM PurchaseDetails  WHERE InvoiceNo = '" + purchaseDetails.InvoiceNo + "'  ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //showDataGridView.DataSource = dataTable;

                //Close
                sqlConnection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                sqlConnection.Close();
            }
            return exists;
        }
        public bool AddPurchase(List<Purchase> purchases)
        {
            
            bool isAdded = false;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            { //open connection
                sqlConnection.Open();
                int purchaseDetailsId = _purchaseDetailsManager.GetLastPurchaseDetailsId();
                foreach (var purchase in purchases)
                {
                    purchase.PurchaseDetailsId = purchaseDetailsId;
                    //string queryString = @"INSERT INTO Purchases VALUES('" + purchase.Date + "','" + purchase.InvoiceNo + "'," + purchase.SupplierId + "," + purchase.ProductId + ",'" + purchase.Code + "','" + purchase.ManufacturedDate + "','" + purchase.ExpireDate + "'," + purchase.Quantity + "," + purchase.UnitPrice + "," + purchase.TotalPrice + "," + purchase.MRP + ",'" + purchase.Remarks + "');";
                    string queryString = @"INSERT INTO Purchases VALUES("+purchase.PurchaseDetailsId+"," + purchase.ProductId + ",'" + purchase.ManufacturedDate + "','" + purchase.ExpireDate + "'," + purchase.Quantity + "," + purchase.UnitPrice + "," + purchase.TotalPrice + "," + purchase.MRP + ",'" + purchase.Remarks + "');";
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

        public string GetLastPurchaseCode()
        {
            string code = "";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Code FROM PurchaseDetails ORDER BY Id DESC ";
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


        public int GetTotalProductById(int id,string purchaseDate )
        {
            int totalQuantity = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT SUM(p.Quantity) AS TotalQuantity FROM Purchases as p where p.ProductId="+id+ "  Group by p.ProductId ";
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

        public int GetTotalProductByIdAndDate(int id,string date)
        {
            int totalQuantity = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT coalesce(Sum(p.Quantity),0) AS TotalQuantity FROM Purchases AS p LEFT JOIN PurchaseDetails AS pd ON pd.Id=p.PurchaseDetailsId WHERE p.ProductId=" + id + " AND pd.Date < '"+date+"' GROUP BY p.ProductId ";
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

        public int GetTotalProductByIdAndStartAndEndDate(int id, string startDate,string endDate)
        {
            int totalQuantity = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT coalesce(Sum(p.Quantity),0) AS TotalQuantity FROM Purchases AS p LEFT JOIN PurchaseDetails AS pd ON pd.Id=p.PurchaseDetailsId WHERE p.ProductId=" + id + " AND pd.Date BETWEEN '"+startDate+"' AND '"+endDate+"' GROUP BY p.ProductId ";
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

        public List<Purchase> GetProductByPurchaseDetailsId(int id)
        {
            List<Purchase> _purchases = new List<Purchase>();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT pro.Name AS Product,p.ManufacturedDate,p.[ExpireDate],p.Quantity,p.UnitPrice,p.TotalPrice,p.MRP,p.Remarks 
                                        FROM Purchases as p 
                                        LEFT JOIN Products AS pro ON p.ProductId=pro.Id 
                                        LEFT JOIN PurchaseDetails AS pd ON pd.Id=p.PurchaseDetailsId WHERE p.PurchaseDetailsId="+id+" ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Purchase purchase=new Purchase();

                    purchase.Product = sqlDataReader["Product"].ToString();
                    purchase.ManufacturedDate =sqlDataReader["ManufacturedDate"].ToString();
                    purchase.ExpireDate= sqlDataReader["ExpireDate"].ToString();
                    purchase.Quantity= Convert.ToInt32(sqlDataReader["Quantity"]);
                    purchase.UnitPrice= Convert.ToInt32(sqlDataReader["UnitPrice"]);
                    purchase.TotalPrice= Convert.ToInt32(sqlDataReader["TotalPrice"]);
                    purchase.MRP= Convert.ToInt32(sqlDataReader["MRP"]);
                    purchase.Remarks= sqlDataReader["Remarks"].ToString();

                    _purchases.Add(purchase);
                }

                //close connection
                sqlConnection.Close();

                return _purchases;
            }
        }

    }
}
