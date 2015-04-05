using Domain;

namespace ImportTools.EntityWorksheets
{
    internal abstract class BaseEntityWorksheet<T> where T : Entity
    {
        public EntityCell[] Cells;

        public abstract T MapToEntity(string[] cellValues);

        //TODO: Create method to resolve a real value from string cell value
    }
}