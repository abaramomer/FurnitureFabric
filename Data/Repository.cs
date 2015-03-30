using System.Data.Entity;
using Domain;

namespace Data
{
    public class Repository
    {
        private FurnitureFabricEntities applicationContext;

        public IDbSet<T> Get<T>() where T : BaseEntity
        {
            applicationContext = new FurnitureFabricEntities();

// ReSharper disable once PossibleNullReferenceException
            return applicationContext.Set<T>();
        }

        public void SaveAndDispose()
        {
            applicationContext.SaveChanges();
            applicationContext.Dispose();
        }
    }
}