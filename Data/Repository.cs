using System.Data;
using System.Data.Entity;
using Domain;

namespace Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected FurnitureFabricEntities ApplicationContext;

        public Repository(FurnitureFabricEntities context)
        {
            ApplicationContext = context;
        }

        public virtual IDbSet<T> Get()
        {
            return ApplicationContext.Set<T>();
        }

        public void SaveAndDispose()
        {
            ApplicationContext.SaveChanges();
            ApplicationContext.Dispose();
        }

        public virtual T InsertOrUpdate(T entity)
        {
            ApplicationContext = new FurnitureFabricEntities();
            ApplicationContext.Set<T>().Add(entity);

            return entity;
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}