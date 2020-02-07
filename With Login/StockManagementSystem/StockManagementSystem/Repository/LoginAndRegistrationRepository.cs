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
    public class LoginAndRegistrationRepository
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public bool Registration(Registration registration)
        {
            bool isAdded = false;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"INSERT INTO Registration VALUES('" + registration.Name + "','" + registration.Email + "','"+registration.Password+"')";
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

        public bool Login(Registration registration)
        {
            bool isFound = true;
            string name = "";

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Name FROM Registration WHERE Email='" + registration.Email + "' AND Password= '" + registration.Password + "' ";
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
    }


  
}
