using System.Data;
using System.Data.Entity;
using Domain;

namespace Data
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected FurnitureFabricEntities Context;

        public Repository(FurnitureFabricEntities context)
        {
            Context = context;
        }

        public virtual IDbSet<T> Get()
        {
            return Context.Set<T>();
        }

        public virtual T InsertOrUpdate(T entity)
        {
            Context.Set<T>().Add(entity);

            return entity;
        }

        internal void SetContext(FurnitureFabricEntities context)
        {
            Context = context;
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}