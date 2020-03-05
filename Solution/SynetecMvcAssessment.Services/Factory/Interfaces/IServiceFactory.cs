using SynetecMvcAssessment.Services.Interfaces;

namespace SynetecServices.Factory
{
    public interface IServiceFactory
    {
        ICalculateBonusService GetCalculateBonusService();
    }
}
