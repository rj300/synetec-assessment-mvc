using SynetecRepositories.Factory;
using SynetecServices.Factory;

namespace SynetecServices
{
    public abstract class BaseService
    {
        protected const int roundTo = 2;
        protected IBaseSynetecRepoFactory RepoFactory;
        protected IServiceFactory ServiceFactory;

        public BaseService()
        {
            RepoFactory = new SynetecRepositoryFactory();
            ServiceFactory = new ServiceFactory();
        }
    }
}
