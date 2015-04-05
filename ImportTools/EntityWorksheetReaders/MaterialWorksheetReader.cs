using Domain;
using ImportTools.EntityWorksheets;
using OfficeOpenXml;

namespace ImportTools.EntityWorksheetReaders
{
    internal class MaterialWorksheetReader : ExcelWorksheetReader<Material, MaterialWorksheet>
    {
        public MaterialWorksheetReader(ExcelWorksheet excelWorksheet)
            : base(excelWorksheet, new MaterialWorksheet())
        {
        }
    }
}