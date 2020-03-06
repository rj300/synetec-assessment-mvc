using SynetecDatabase.Data;
using SynetecServices.Interfaces;
using System.Collections.Generic;

namespace SynetecServices
{
    public class EmployeesService: BaseService, IEmployeesService
    {
        public HrEmployee Get(int empId)
        {
            return RepoFactory.EmployeeRepository().Get(empId);
        }

        public List<HrEmployee> GetAll()
        {
            return RepoFactory.EmployeeRepository().GetAll();
        }
    }
}
