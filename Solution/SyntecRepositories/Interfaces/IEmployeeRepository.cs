using SynetecDatabase.Data;
using System.Collections.Generic;

namespace SynetecRepositories.Interfaces
{
    public interface IEmployeeRepository
    {
        List<HrEmployee> GetAll();
        HrEmployee Get(int Id);
        //additionally can have save, update and delete for employees
    }
}
