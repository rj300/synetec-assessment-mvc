using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecMvcAssessment.Services.Interfaces
{
    public interface ICalculateBonusService
    {
        int EmployeeBonusPoolAllocation(int empId, int totalBonusPool);
    }
}
