using System.Collections.Generic;
using Domain;
using ImportTools.EntityWorksheets;

namespace ImportTools
{
    internal abstract class WorksheetReader<TEntity, TEntityWorksheet> 
        where TEntity : Entity 
        where TEntityWorksheet : BaseEntityWorksheet<TEntity>
    {
        protected TEntityWorksheet EntityWorksheet;
        
        protected WorksheetReader(TEntityWorksheet entityWorksheet)
        {
            EntityWorksheet = entityWorksheet;
        }

        public abstract List<TEntity> Read();
    }
}
