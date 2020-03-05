using SynetecData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynetecServices.Interfaces
{
    public interface IEmployeesService
    {
        HrEmployee Get(int empId);
        List<HrEmployee> GetAll();
    }
}
