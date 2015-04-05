using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Domain;
using ImportTools.EntityWorksheetReaders;
using OfficeOpenXml;

namespace ImportTools
{
    public class ExcelImportService
    {
        private readonly Dictionary<Type, Func<ExcelWorksheet, IEntityWorksheetReader>> mappedWorksheetTypes;

        private IEntityWorksheetReader excelWorksheetReader;

        public ExcelImportService()
        {
            mappedWorksheetTypes = new Dictionary<Type, Func<ExcelWorksheet, IEntityWorksheetReader>>();
        }

        public List<Entity> Import(FileInfo fileInfo, Type entityType)
        {
            Map();

            using (var excelDocument = new ExcelPackage(fileInfo))
            {
                var fistWorksheet = excelDocument.Workbook.Worksheets.First();
                excelWorksheetReader = mappedWorksheetTypes[entityType](fistWorksheet);
                var exportedEntities = excelWorksheetReader.Read();

                return exportedEntities;
            }
        }

        private void Map()
        {
            mappedWorksheetTypes.Add(typeof(FurnitureModel), worksheet => new FurnitureModelWorksheetReader(worksheet));
            mappedWorksheetTypes.Add(typeof(Material), worksheet => new MaterialWorksheetReader(worksheet));
        }
    }
}
