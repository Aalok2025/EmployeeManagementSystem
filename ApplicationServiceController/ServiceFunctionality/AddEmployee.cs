using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ApplicationServiceController.ServiceRepository;

namespace ApplicationServiceController.ServiceFunctionality
{
    public delegate void Notify<T>(T entity);
    public delegate void Log<T>(T entity);
    public class AddEmployee<T> : IAddEmployeeRepo<T> where T : Employee
    {
        private readonly string connectionString;
        public AddEmployee(string connectionDB) 
        {
            if(string.IsNullOrEmpty(connectionDB))
            {
                throw new ArgumentNullException("Connection string is null or empty");
            }
            connectionString = connectionDB;

        }
        T IAddEmployeeRepo<T>.AddEmployee(T entity)
        {
            if(entity is Employee)
            {
                //get id, salary
                entity.Salary = EmployeeProperties.GetSalary(entity.Age,entity.dept);
                //get connection to db
                string query = "INSERT INTO Employee (Name, Age, Department, Salary) VALUES (@Name, @Age, @Department, @Salary)";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            //cmd.Parameters.AddWithValue("@Id", entity.id);
                            cmd.Parameters.AddWithValue("@Name", entity.Name);
                            cmd.Parameters.AddWithValue("@Age", entity.Age);
                            cmd.Parameters.AddWithValue("@Department", entity.dept.ToString());
                            cmd.Parameters.AddWithValue("@Salary", entity.Salary);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine($"Employee {entity.Name} added successfully");
                                //SqlLog
                                Log.Logging.sqlLog(query, new List<string> {entity.Name,entity.Age.ToString(),entity.dept.ToString(),entity.Salary.ToString()});

                                //Log
                                Log.Logging.Log($"Employee {entity.Name} added successfully");

                                //notify
                                Notify<Employee> notify = new Notify<Employee>(SendEmail);
                                notify((Employee)(object)entity);
                            }
                            return entity;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Database error: " + ex.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public void SendEmail<A>(A emp) where A : Employee
        {
            Console.WriteLine($"Email sent to {emp.Name}");
        }
    }
}
