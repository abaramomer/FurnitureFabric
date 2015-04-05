using System.Collections.Generic;
using Domain;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;

namespace ImportTools
{
    public interface IExcelWorksheetReader
    {
        List<T> Read<T>() where T : Entity;
    }
}