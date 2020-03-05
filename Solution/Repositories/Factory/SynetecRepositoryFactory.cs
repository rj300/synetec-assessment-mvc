using System;
using System.Collections.Generic;
using System.Text;
using SynetecRepositories.Factory.Interfaces;

namespace SynetecRepositories.Factory
{
    class SynetecRepositoryFactory : IBaseSynetecRepoFactory
    {
        public IDepartmentRepository DepartmentRespository()
        {
            return new DepartmentRepository();
        }

        public IEmployeeRepository EmployeeRepository()
        {
            return new EmployeeRepository();
        }
    }
}
