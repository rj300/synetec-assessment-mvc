using SynetecDatabase.Data;
using System.Collections.Generic;

namespace SynetecServices.Interfaces
{
    public interface IEmployeesService
    {
        HrEmployee Get(int empId);
        List<HrEmployee> GetAll();
    }
}
