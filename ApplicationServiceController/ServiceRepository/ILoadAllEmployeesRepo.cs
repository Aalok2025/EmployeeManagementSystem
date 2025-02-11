using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServiceController.ServiceRepository
{
    public interface ILoadAllEmployeesRepo<T> where T : Employee
    {
        DataTable LoadAllEmployees();
    }
}
