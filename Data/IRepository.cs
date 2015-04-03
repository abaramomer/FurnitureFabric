using System.Data.Entity;
using Domain;

namespace Data
{
    public interface IRepository<T> where T : Entity
    {
        T InsertOrUpdate(T entity);

        IDbSet<T> Get();

        void Delete(T entity);
    }
}