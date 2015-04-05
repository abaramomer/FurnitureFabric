using System.Collections.Generic;
using OfficeOpenXml;

namespace ImportTools.Extensions
{
    internal static class ExcelWorksheetExtensions
    {
        public static List<string> GetValuesByRowNumber(this ExcelWorksheet excelWorksheet, int rowNumber, int startIndex, int endIndex)
        {
            var values = new List<string>();

            for (int i = startIndex; i <= endIndex; i++)
            {
                values.Add(excelWorksheet.Cells[rowNumber, i].Text);
            }

            return values;
        }
    }
}