using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using StockManagementSystem.Manager;
using StockManagementSystem.Model;

namespace StockManagementSystem.Repository
{
    public class SharedRepository
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        PurchaseManager _purchaseManager=new PurchaseManager();
        SalesManager _salesManager=new SalesManager();

        public List<PurchaseReportViewModel> GetPurchaseReport(string startDate, string endDate)
        {
            List<PurchaseReportViewModel> purchaseReportViewModels = new List<PurchaseReportViewModel>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT p.Id, p.Code AS Code,p.Name AS Name ,c.Name AS Category,SUM(pur.Quantity) AS AvailableQty,SUM(pur.TotalPrice) AS CP ,SUM(MRP*pur.Quantity) AS MRP,SUM(MRP*pur.Quantity-pur.TotalPrice) AS Profit 
 FROM Purchases AS pur LEFT JOIN Products AS p ON p.Id=pur.ProductId 
 LEFT JOIN Categories AS c ON p.CategoryId=c.Id GROUP BY p.Id, p.Code,p.Name,c.Name ORDER BY p.Code";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    int productId = Convert.ToInt32(sqlDataReader["Id"]);
                    int purchaseQuantity = _purchaseManager.GetTotalProductByIdAndDate(productId, startDate);
                    int salesQuantity = _salesManager.GetTotalProductByIdAndDate(productId, startDate);
                    int inQty = _purchaseManager.GetTotalProductByIdAndStartAndEndDate(productId, startDate, endDate);
                    int outQty = _salesManager.GetTotalProductByIdAndStartAndEndDate(productId, startDate, endDate);



                    PurchaseReportViewModel model = new PurchaseReportViewModel();
                    model.Code = sqlDataReader["Code"].ToString();
                    model.Name = sqlDataReader["Name"].ToString();
                    model.Category= sqlDataReader["Category"].ToString();
                    //model.AvailableQty = Convert.ToInt32(sqlDataReader["AvailableQty"]);
                    model.AvailableQty = (purchaseQuantity - salesQuantity) + inQty - outQty;
                    model.CP = Convert.ToDouble(sqlDataReader["CP"]);
                    model.MRP = Convert.ToDouble(sqlDataReader["MRP"]);
                    model.Profit = Convert.ToDouble(sqlDataReader["Profit"]);
                    purchaseReportViewModels.Add(model);
                }
            }

            return purchaseReportViewModels;

        }
        public List<PurchaseReportViewModel> SearchPurchaseReportByDate(string startDate, string endDate)
        {
            List<PurchaseReportViewModel> purchaseReportViewModels = new List<PurchaseReportViewModel>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT p.Id, p.Code AS Code,p.Name AS Name ,c.Name AS Category,SUM(pur.Quantity) AS AvailableQty,SUM(pur.TotalPrice) AS CP ,SUM(MRP*pur.Quantity) AS MRP,SUM(MRP*pur.Quantity-pur.TotalPrice) AS Profit 
 FROM Purchases AS pur LEFT JOIN PurchaseDetails AS pd ON pd.Id=pur.PurchaseDetailsId LEFT JOIN Products AS p ON p.Id=pur.ProductId 
 LEFT JOIN Categories AS c ON p.CategoryId=c.Id WHERE pd.Date BETWEEN '" + startDate+"' AND '"+endDate+"'  GROUP BY p.Id, p.Code,p.Name,c.Name ORDER BY p.Code";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    int productId = Convert.ToInt32(sqlDataReader["Id"]);
                    //int purchaseQuantity = _purchaseManager.GetTotalProductById(productId);
                    //int salesQuantity = _salesManager.GetTotalProductById(productId);

                    int purchaseQuantity = _purchaseManager.GetTotalProductByIdAndDate(productId, startDate);
                    int salesQuantity = _salesManager.GetTotalProductByIdAndDate(productId, startDate);
                    int inQty = _purchaseManager.GetTotalProductByIdAndStartAndEndDate(productId, startDate, endDate);
                    int outQty = _salesManager.GetTotalProductByIdAndStartAndEndDate(productId, startDate, endDate);

                    PurchaseReportViewModel model = new PurchaseReportViewModel();
                    model.Code = sqlDataReader["Code"].ToString();
                    model.Name = sqlDataReader["Name"].ToString();
                    model.Category = sqlDataReader["Category"].ToString();
                    //model.AvailableQty = Convert.ToInt32(sqlDataReader["AvailableQty"]);
                    model.AvailableQty = (purchaseQuantity - salesQuantity)+inQty-outQty;
                    model.CP = Convert.ToDouble(sqlDataReader["CP"]);
                    model.MRP = Convert.ToDouble(sqlDataReader["MRP"]);
                    model.Profit = Convert.ToDouble(sqlDataReader["Profit"]);
                    purchaseReportViewModels.Add(model);
                }
            }

            return purchaseReportViewModels;

        }


        public List<SalesReportViewModel> GetSalesReport()
        {
            List<SalesReportViewModel> salesReportViewModels = new List<SalesReportViewModel>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT p.Id, p.Code AS Code,p.Name AS Name ,c.Name AS Category,SUM(s.Quantity) AS SoldQty ,SUM(MRP*s.Quantity) AS SalesPrice
                 FROM Sales AS s LEFT JOIN Products AS p ON p.Id=s.ProductId 
                 LEFT JOIN Categories AS c ON p.CategoryId=c.Id  GROUP BY p.Id, p.Code,p.Name,c.Name ORDER BY p.Code";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    int productId = Convert.ToInt32(sqlDataReader["Id"]);
                    Purchase purchase=new Purchase();
                    purchase = _purchaseManager.GetLastPurchasesProductInfoById(productId);
                    


                    SalesReportViewModel model = new SalesReportViewModel();
                    model.Code = sqlDataReader["Code"].ToString();
                    model.Name = sqlDataReader["Name"].ToString();
                    model.Category = sqlDataReader["Category"].ToString();
                    model.SoldQty = Convert.ToInt32(sqlDataReader["SoldQty"]);
                    // model.CP = Convert.ToDouble(sqlDataReader["CP"]);
                    model.CP = model.SoldQty * purchase.UnitPrice;
                    model.SalesPrice = Convert.ToDouble(sqlDataReader["SalesPrice"]);
                    // model.Profit = Convert.ToDouble(sqlDataReader["Profit"]);
                    model.Profit = model.SalesPrice - model.CP;
                    salesReportViewModels.Add(model);
                }
            }

            return salesReportViewModels;
        }

        public List<SalesReportViewModel> SearchSalesReportByDate(string startDate, string endDate)
        {

            List<SalesReportViewModel> salesReportViewModels = new List<SalesReportViewModel>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT p.Id, p.Code AS Code,p.Name AS Name ,c.Name AS Category,SUM(s.Quantity) AS SoldQty ,SUM(MRP*s.Quantity) AS SalesPrice
                 FROM Sales AS s LEFT JOIN Products AS p ON p.Id=s.ProductId 
                 LEFT JOIN Categories AS c ON p.CategoryId=c.Id WHERE s.Date BETWEEN '" + startDate + "' AND '" + endDate + "'  GROUP BY p.Id, p.Code,p.Name,c.Name ORDER BY p.Code";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    int productId = Convert.ToInt32(sqlDataReader["Id"]);
                    Purchase purchase = new Purchase();
                    purchase = _purchaseManager.GetLastPurchasesProductInfoById(productId);



                    SalesReportViewModel model = new SalesReportViewModel();
                    model.Code = sqlDataReader["Code"].ToString();
                    model.Name = sqlDataReader["Name"].ToString();
                    model.Category = sqlDataReader["Category"].ToString();
                    model.SoldQty = Convert.ToInt32(sqlDataReader["SoldQty"]);
                    // model.CP = Convert.ToDouble(sqlDataReader["CP"]);
                    model.CP = model.SoldQty * purchase.UnitPrice;
                    model.SalesPrice = Convert.ToDouble(sqlDataReader["SalesPrice"]);
                    // model.Profit = Convert.ToDouble(sqlDataReader["Profit"]);
                    model.Profit = model.SalesPrice - model.CP;
                    salesReportViewModels.Add(model);
                }
            }

            return salesReportViewModels;
        }


        public List<Stock> GetStockReport(string startDate, string endDate)
        {
            List<Stock> stocks = new List<Stock>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT p.Id, p.Code AS Code,
                                    p.Name AS Product,
                                    c.Name AS Category,p.ReorderLevel As ReorderLevel
                                     FROM Purchases As pur
                                     LEFT JOIN Sales AS s ON s.ProductId=pur.ProductId
                                     LEFT JOIN Products As p ON pur.ProductId=p.Id 
                                     LEFT JOIN Categories as c ON p.CategoryId=c.Id 
                                     GROUP BY p.Id, p.Code,p.Name,p.ReorderLevel,c.Name,pur.ProductId";

                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    int productId = Convert.ToInt32(sqlDataReader["Id"]);
                    int purchaseQty = _purchaseManager.GetTotalProductByIdAndDate(productId, startDate);
                    int salesQty = _salesManager.GetTotalProductByIdAndDate(productId, startDate);

                    int inQty = _purchaseManager.GetTotalProductByIdAndStartAndEndDate(productId, startDate, endDate);
                    int outQty = _salesManager.GetTotalProductByIdAndStartAndEndDate(productId, startDate, endDate);

                    Stock model = new Stock();
                    model.Code = sqlDataReader["Code"].ToString();
                    model.Product = sqlDataReader["Product"].ToString();
                    model.Category = sqlDataReader["Category"].ToString();
                    model.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                    //model.ExpiredDate = "2019-10-26";
                    //model.ExpiredQuantity = 3;
                    model.OpeningBalance = purchaseQty - salesQty;
                    model.In = inQty;
                    model.Out = outQty;
                    model.ClosingBalance =model.OpeningBalance+ inQty-outQty;

                    stocks.Add(model);
                }
            }

            return stocks;
        }

        public List<Stock> SearchStockReportByDate(string startDate, string endDate, int categoryId,int productId)
        {
            List<Stock> stocks = new List<Stock>();
            string queryString = "";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                if (categoryId!=0)
                {
                    queryString = @"SELECT p.Id, p.Code AS Code,
                                    p.Name AS Product,
                                    c.Name AS Category,p.ReorderLevel As ReorderLevel
                                     FROM Purchases As pur
                                     LEFT JOIN Sales AS s ON s.ProductId=pur.ProductId
                                     LEFT JOIN Products As p ON pur.ProductId=p.Id 
                                     LEFT JOIN Categories as c ON p.CategoryId=c.Id
                                     WHERE c.Id = "+ categoryId + " GROUP BY p.Id, p.Code,p.Name,p.ReorderLevel,c.Name,pur.ProductId";
                }

                if (productId != 0)
                {
                    queryString = @"SELECT p.Id, p.Code AS Code,
                                    p.Name AS Product,
                                    c.Name AS Category,p.ReorderLevel As ReorderLevel
                                     FROM Purchases As pur
                                     LEFT JOIN Sales AS s ON s.ProductId=pur.ProductId
                                     LEFT JOIN Products As p ON pur.ProductId=p.Id 
                                     LEFT JOIN Categories as c ON p.CategoryId=c.Id 
                                     WHERE p.Id = " + productId + "  GROUP BY p.Id, p.Code,p.Name,p.ReorderLevel,c.Name,pur.ProductId";
                }

                if (categoryId==0 && productId==0)
                {
                    queryString = @"SELECT p.Id, p.Code AS Code,
                                    p.Name AS Product,
                                    c.Name AS Category,p.ReorderLevel As ReorderLevel
                                     FROM Purchases As pur
                                     LEFT JOIN Sales AS s ON s.ProductId=pur.ProductId
                                     LEFT JOIN Products As p ON pur.ProductId=p.Id 
                                     LEFT JOIN Categories as c ON p.CategoryId=c.Id 
                                     GROUP BY p.Id, p.Code,p.Name,p.ReorderLevel,c.Name,pur.ProductId";
                }

                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    int proId = Convert.ToInt32(sqlDataReader["Id"]);
                    int purchaseQty = _purchaseManager.GetTotalProductByIdAndDate(proId, startDate);
                    int salesQty = _salesManager.GetTotalProductByIdAndDate(proId, startDate);

                    int inQty = _purchaseManager.GetTotalProductByIdAndStartAndEndDate(proId, startDate, endDate);
                    int outQty = _salesManager.GetTotalProductByIdAndStartAndEndDate(proId, startDate, endDate);

                    Stock model = new Stock();
                    model.Code = sqlDataReader["Code"].ToString();
                    model.Product = sqlDataReader["Product"].ToString();
                    model.Category = sqlDataReader["Category"].ToString();
                    model.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                    //model.ExpiredDate = "2019-10-26";
                    //model.ExpiredQuantity = 3;
                    model.OpeningBalance = purchaseQty - salesQty; ;
                    model.In = inQty;
                    model.Out = outQty;
                    model.ClosingBalance = model.OpeningBalance + inQty - outQty;

                    stocks.Add(model);
                }
            }
            return stocks;
        }


    }
}
