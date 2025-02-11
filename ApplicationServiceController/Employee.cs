using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServiceController
{
    public class Employee
    {
        public int id;
        public string Name { get; set; }
        public int Age { get; set; }
        public Department dept { get; set; }
       public decimal Salary { get; set; }
       public Employee(int id, string Name, int Age, Department dept, decimal Salary)
       {
            this.id = id;
            this.Name = Name;
            this.dept = dept;
            this.Age = Age;
            this.Salary = Salary;
        }
        public Employee(string Name, int Age, Department dept)
        {
            this.Name = Name;
            this.Age = Age;
            this.dept = dept;
        }
    }
}
