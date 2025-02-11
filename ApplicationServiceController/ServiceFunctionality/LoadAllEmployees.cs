using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServiceController.ServiceRepository;

namespace ApplicationServiceController.ServiceFunctionality
{
    public class LoadAllEmployees<T> : ILoadAllEmployeesRepo<T> where T : Employee
    {
        private readonly string connectionString;
        public LoadAllEmployees(string connectionDB)
        {
            if (string.IsNullOrEmpty(connectionDB))
            {
                throw new ArgumentNullException("Connection string is null or empty");
            }
            connectionString = connectionDB;
        }

        DataTable ILoadAllEmployeesRepo<T>.LoadAllEmployees()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Employee";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                            //SqlLog
                            Log.Logging.sqlLog(query, new List<string> {});

                            //Log
                            Log.Logging.Log($"Data Loaded successfully");

                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return dt;
        }
    }
}
