using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServiceController.ServiceRepository
{
    public interface IAddEmployeeRepo<T> where T : Employee
    {
        T AddEmployee(T entity);
    }
}
