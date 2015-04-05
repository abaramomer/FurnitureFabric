using System.Collections.Generic;
using Domain;

namespace ImportTools.EntityWorksheets
{
    internal abstract class BaseEntityWorksheet<T> where T : Entity
    {
        public EntityCell[] Cells;

        public abstract T MapToEntity(string[] cellValues);
    }
}