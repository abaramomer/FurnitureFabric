using System.Collections.Generic;
using Domain;

namespace ImportTools.EntityWorksheetReaders
{
    public interface IEntityWorksheetReader
    {
        List<Entity> Read();
    }
}