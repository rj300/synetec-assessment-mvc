using SynetecMvcAssessment.Services.Interfaces;
using SynetecRepositories.Factory;
using SynetecServices;
using System;

namespace SynetecMvcAssessment.Services
{
    public class CalculateBonusService : BaseService, ICalculateBonusService
    {
        public decimal CalculateEmployeeBonusPoolAllocation(int empId, int totalBonusPool)
        {
            var employee = RepoFactory.EmployeeRepository().Get(empId);
            var totalOrganisationSalary = RepoFactory.OrganisationRepository().GetOrganisationTotalSalary();
            decimal bonusPercentage = (employee.Salary / (decimal)totalOrganisationSalary);
            decimal bonusAllocation = (decimal.Round(bonusPercentage, roundTo) * totalBonusPool);

            return decimal.Round(bonusAllocation, roundTo, MidpointRounding.AwayFromZero);
        }
    }
}
