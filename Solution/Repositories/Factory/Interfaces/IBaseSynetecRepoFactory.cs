using SynetecRepositories.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecRepositories.Factory
{
    interface IBaseSynetecRepoFactory
    {
        IDepartmentRepository DepartmentRespository();
        IEmployeeRepository EmployeeRepository();
    }
}
