using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;

namespace StockManagementSystem.Repository
{
    public class PurchaseDetailsRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public bool AddPurchaseDetails(PurchaseDetails purchaseDetails)
        {

            bool isAdded = false;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            { //open connection
                sqlConnection.Open();
               
                    //string queryString = @"INSERT INTO Purchases VALUES('" + purchase.Date + "','" + purchase.InvoiceNo + "'," + purchase.SupplierId + "," + purchase.ProductId + ",'" + purchase.Code + "','" + purchase.ManufacturedDate + "','" + purchase.ExpireDate + "'," + purchase.Quantity + "," + purchase.UnitPrice + "," + purchase.TotalPrice + "," + purchase.MRP + ",'" + purchase.Remarks + "');";
                    string queryString = @"INSERT INTO PurchaseDetails VALUES('"+purchaseDetails.Date+"','"+purchaseDetails.InvoiceNo+"','"+purchaseDetails.Code+"',"+purchaseDetails.SupplierId+")";
                    SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);


                    int isExecuted = sqlCommand.ExecuteNonQuery();


                    if (isExecuted > 0)
                    {
                        isAdded = true;
                    }
                
                //close connection
                sqlConnection.Close();

            }

            return isAdded;
        }
        public List<PurchaseDetails> GetAllPurchaseDetails()
        {
            List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT p.Id,p.SupplierId,p.[Date],p.InvoiceNo,p.Code, s.Name As Supplier FROM PurchaseDetails AS p LEFT JOIN Suppliers AS s ON s.Id=p.SupplierId ORDER BY p.Id DESC";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    PurchaseDetails purchaseDetail = new PurchaseDetails();

                    purchaseDetail.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    purchaseDetail.Date = sqlDataReader["Date"].ToString();
                    purchaseDetail.InvoiceNo = sqlDataReader["InvoiceNo"].ToString();
                    purchaseDetail.Code = sqlDataReader["Code"].ToString();
                    purchaseDetail.SupplierId =Convert.ToInt32(sqlDataReader["SupplierId"]);
                    purchaseDetail.Supplier = sqlDataReader["Supplier"].ToString();
                  
                    purchaseDetails.Add(purchaseDetail);

                }

                //close connection
                sqlConnection.Close();

                return purchaseDetails;
            }
        }
        public int GetLastPurchaseDetailsId()
        {
            int id = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Id FROM PurchaseDetails ORDER BY Id DESC ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    id = Convert.ToInt32(sqlDataReader["Id"].ToString());
                    break;
                }

                //close connection
                sqlConnection.Close();

            }

            return id;
        }
        public List<PurchaseDetails> GetPurchaseDetailsByDate(string startDate,string endDate)
        {
            List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT p.Id,p.SupplierId,p.[Date],p.InvoiceNo,p.Code, s.Name As Supplier FROM PurchaseDetails AS p LEFT JOIN Suppliers AS s ON s.Id=p.SupplierId WHERE p.Date BETWEEN '"+startDate+ "' AND  '" + endDate + "' ORDER BY p.Id DESC";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    PurchaseDetails purchaseDetail = new PurchaseDetails();

                    purchaseDetail.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    purchaseDetail.Date = sqlDataReader["Date"].ToString();
                    purchaseDetail.InvoiceNo = sqlDataReader["InvoiceNo"].ToString();
                    purchaseDetail.Code = sqlDataReader["Code"].ToString();
                    purchaseDetail.SupplierId = Convert.ToInt32(sqlDataReader["SupplierId"]);
                    purchaseDetail.Supplier = sqlDataReader["Supplier"].ToString();

                    purchaseDetails.Add(purchaseDetail);

                }

                //close connection
                sqlConnection.Close();

                return purchaseDetails;
            }
        }
    }
}
