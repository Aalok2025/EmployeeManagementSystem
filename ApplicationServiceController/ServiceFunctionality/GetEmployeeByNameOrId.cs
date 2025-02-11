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
    public class GetEmployeeByNameOrId<T> : IGetEmployeeByNameOrId<Employee>
    {
        private readonly string connectionString;
        public GetEmployeeByNameOrId(string connectionDB)
        {
            if (string.IsNullOrEmpty(connectionDB))
            {
                throw new ArgumentNullException("Connection string is null or empty");
            }
            connectionString = connectionDB;
        }

        public DataTable GetEmployeeById<T1>(T1 id)
        {
            DataTable dt = new DataTable(); 
            string query = "SELECT * from Employee WHERE Id=@Id;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        Console.WriteLine($"Employee with {id} displayed successfully");
                        //SqlLog
                        Log.Logging.sqlLog(query, new List<string> { id.ToString() });
                        //Log
                        Log.Logging.Log($"Employee with {id} displayed successfully");
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public DataTable GetEmployeeByName<T1>(T1 name)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * from Employee WHERE Name=@Name;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name",name );

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        Console.WriteLine($"Employee Details with {name} displayed successfully");
                        //SqlLog
                        Log.Logging.sqlLog(query, new List<string> { name.ToString() });
                        //Log
                        Log.Logging.Log($"Employee with {name} displayed successfully");
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
