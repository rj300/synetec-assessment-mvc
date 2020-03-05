using SynetecMvcAssessment.Services.Interfaces;
using SynetecServices.Interfaces;

namespace SynetecServices.Factory
{
    public interface IServiceFactory
    {
        ICalculateBonusService GetCalculateBonusService();
        IEmployeesService GetEmployeesService();
    }
}
