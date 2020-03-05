using System;
using System.Collections.Generic;
using System.Text;
using SynetecMvcAssessment.Services;
using SynetecMvcAssessment.Services.Interfaces;
using SynetecServices.Interfaces;

namespace SynetecServices.Factory
{
    public class ServiceFactory : IServiceFactory
    {
        public ICalculateBonusService GetCalculateBonusService()
        {
            return new CalculateBonusService();
        }

        public IEmployeesService GetEmployeesService()
        {
            return new EmployeesService();
        }
    }
}
