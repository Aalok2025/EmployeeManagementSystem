using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServiceController
{
    public class EmployeeProperties
    {
        public static decimal GetSalary<T,U>(T entity1, U entity2) where T : struct
        {
            decimal salary = 0;
            if (entity1 is int age && age>= 18 && age< 60)
            {
                    if (entity2.Equals(Department.IT))
                    {
                        salary = 50000;
                    }
                    else if (entity2.Equals(Department.HR))
                    {
                        salary = 40000;
                    }
                    else if (entity2.Equals(Department.Finance))
                    {
                        salary = 45000;
                    }
            }
            return salary;
        }
    }
}
