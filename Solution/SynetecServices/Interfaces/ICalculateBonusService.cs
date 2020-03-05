using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecMvcAssessment.Services.Interfaces
{
    public interface ICalculateBonusService
    {
        decimal CalculateEmployeeBonusPoolAllocation(int empId, int totalBonusPool);
    }
}
