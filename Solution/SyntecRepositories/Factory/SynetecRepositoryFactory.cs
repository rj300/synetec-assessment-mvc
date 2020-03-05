using System;
using System.Collections.Generic;
using System.Text;
using SynetecRepositories.Interfaces;
using SynetecRepositories;

namespace SynetecRepositories.Factory
{
    public class SynetecRepositoryFactory : IBaseSynetecRepoFactory
    {
        public IDepartmentRepository DepartmentRepository()
        {
            return new DepartmentRepository();
        }

        public IEmployeeRepository EmployeeRepository()
        {
            return new EmployeeRepository();
        }

        public IOrganisationRepository OrganisationRepository()
        {
            return new OrganisationRepository();
        }
    }
}
