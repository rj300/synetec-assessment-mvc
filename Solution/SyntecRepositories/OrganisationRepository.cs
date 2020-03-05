using SynetecRepositories.Interfaces;
using SynetecRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynetecRepositories
{
    public class OrganisationRepository : BaseRepository, IOrganisationRepository
    {
        public int GetOrganisationTotalSalary()
        {
            return db.HrEmployees.Sum(item => item.Salary);
        }
    }
}
