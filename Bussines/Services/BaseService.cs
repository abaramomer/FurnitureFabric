using Data;

namespace Bussines.Services
{
    public abstract class BaseService
    {
        protected Repository Repository;

        protected BaseService()
        {
            Repository = new Repository();
        }

        protected void Commit()
        {
            Repository.SaveAndDispose();
        }
    }
}
