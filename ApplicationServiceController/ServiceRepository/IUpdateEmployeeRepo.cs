using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServiceController.ServiceRepository
{
    public interface IUpdateEmployeeRepo<T> where T : Employee
    {
        public bool UpdateEmployeeById<T>(T emp) where T : Employee;
    }
}
