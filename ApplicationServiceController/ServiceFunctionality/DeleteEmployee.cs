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
    public class DeleteEmployee<T> : IDeleteEmployeeRepo<T>
    {
        private readonly string connectionString;
        public DeleteEmployee(string connectToDB) 
        {
            connectionString = connectToDB;
        }
        public bool DeleteEmployeeById<T>(T id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Please select a valid entry to delete!");
            }
            string query = "DELETE FROM Employee WHERE Id=@Id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Employee with {id} deleted successfully");
                            //SqlLog
                            Log.Logging.sqlLog(query, new List<string> {id.ToString()});

                            //Log
                            Log.Logging.Log($"Employee with {id} added successfully");

                            //notify
                            Notify<int> notify = new Notify<int>(SendEmail);
                            notify(Convert.ToInt32(id));
                        }
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
                return false;
            }
            return false;
        }
        public void SendEmail<A>(A emp) where A:struct
        {
            Console.WriteLine($"Email sent to employee with id {emp}");
        }
    }
}
