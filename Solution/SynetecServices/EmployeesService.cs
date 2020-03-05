using SynetecData.Data;
using SynetecServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
