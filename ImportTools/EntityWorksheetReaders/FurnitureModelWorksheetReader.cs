using Domain;
using ImportTools.EntityWorksheets;
using OfficeOpenXml;

namespace ImportTools.EntityWorksheetReaders
{
    internal class FurnitureModelWorksheetReader : ExcelWorksheetReader<FurnitureModel, FurnitureModelWorksheet>
    {
        public FurnitureModelWorksheetReader(ExcelWorksheet excelWorksheet)
            : base(excelWorksheet, new FurnitureModelWorksheet())
        {
        }
    }
}