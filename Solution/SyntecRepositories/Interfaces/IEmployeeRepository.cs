using SynetecData.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecRepositories.Interfaces
{
    public interface IEmployeeRepository
    {
        List<HrEmployee> GetAll();
        HrEmployee Get(int Id);
        //additionally can have save, update and delete for employees
    }
}
