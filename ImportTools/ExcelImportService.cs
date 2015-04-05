using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Domain;
using ImportTools.EntityWorksheets;
using ImportTools.Exceptions;
using OfficeOpenXml;

namespace ImportTools
{
    public class ExcelImportService
    {
        private Dictionary<Type, Action<ExcelWorksheet>> mappingActions;

        private IExcelWorksheetReader excelWorksheetReader; 

        public void Import(FileInfo fileInfo, Type entityType)
        {
            Map();

            using (var excelDocument = new ExcelPackage(fileInfo))
            {
                var fistWorksheet = excelDocument.Workbook.Worksheets.First();
                mappingActions[entityType](fistWorksheet);
            }
        }

        private void Map()
        {
            mappingActions.Add(typeof (FurnitureModel), (worksheet) => new FurnitureModelWorksheetReader(worksheet));
        }
    }
}
