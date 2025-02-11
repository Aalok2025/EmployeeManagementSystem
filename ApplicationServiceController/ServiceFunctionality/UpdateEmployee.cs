using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServiceController.ServiceRepository;

namespace ApplicationServiceController.ServiceFunctionality
{
    public class UpdateEmployee<T> : IUpdateEmployeeRepo<T> where T : Employee
    {
        private readonly string connectionString;
        public UpdateEmployee(string connectToDB)
        {
            connectionString = connectToDB;
        }
        public bool UpdateEmployeeById<T>(T emp) where T : Employee
        {
            if (emp == null)
            {
                throw new ArgumentNullException("Please select a valid entry to update!");
            }
            string query = "UPDATE Employee SET Name=@Name, Age=@Age, Department=@Department WHERE Id=@Id";
            if (emp is Employee)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", emp.id);
                            cmd.Parameters.AddWithValue("@Name", emp.Name);
                            cmd.Parameters.AddWithValue("@Age", emp.Age);
                            cmd.Parameters.AddWithValue("@Department", emp.dept.ToString());

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine($"Employee with {emp.id} updated successfully");
                                //SqlLog
                                Log.Logging.sqlLog(query, new List<string> {emp.id.ToString(), emp.Name,emp.Age.ToString(), emp.dept.ToString(), emp.Salary.ToString()});

                                //Log
                                Log.Logging.Log($"Employee {emp.Name}'s details updated successfully");

                                //notify
                                Notify<Employee> notify = new Notify<Employee>(SendEmail);
                                notify((Employee)(Object)emp);
                                return true;
                            }
                        }
                    }
                }

                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database error: " + ex.Message);
                    return false;
                }
            }
            return false;
        }
        public void SendEmail<A>(A emp) where A : Employee
        {
            Console.WriteLine($"Email sent to employee {emp.Name} regarding updates!");
        }
    }
}
