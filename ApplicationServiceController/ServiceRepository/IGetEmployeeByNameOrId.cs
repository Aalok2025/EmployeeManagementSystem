using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServiceController.ServiceRepository
{
    public interface IGetEmployeeByNameOrId<T>
    {
        DataTable GetEmployeeById<T>(T id);
        DataTable GetEmployeeByName<T>(T name);
    }
}
