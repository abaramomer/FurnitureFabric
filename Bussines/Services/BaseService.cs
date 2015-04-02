using Data;

namespace Bussines.Services
{
    public abstract class BaseService
    {
        protected UnitOfWork UnitOfWork;

        protected BaseService()
        {
            UnitOfWork = new UnitOfWork();
        }
    }
}
