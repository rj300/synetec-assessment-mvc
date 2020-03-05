using SynetecRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecRepositories.Factory
{
    public interface IBaseSynetecRepoFactory
    {
        IDepartmentRepository DepartmentRepository();
        IEmployeeRepository EmployeeRepository();
        IOrganisationRepository OrganisationRepository();
    }
}
