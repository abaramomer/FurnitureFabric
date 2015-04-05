using System.Collections.Generic;
using System.Linq;
using Domain;
using ImportTools.EntityWorksheets;
using ImportTools.Exceptions;
using ImportTools.Extensions;
using OfficeOpenXml;

namespace ImportTools
{
    internal class ExcelWorksheetReader<TEntity, TEntityWorksheet> : WorksheetReader<TEntity, TEntityWorksheet>
        where TEntity : Entity
        where TEntityWorksheet : BaseEntityWorksheet<TEntity>,
        IExcelWorksheetReader
    {
        protected ExcelWorksheet ExcelWorksheet;
        private readonly int worksheetColumnsCount;
        private const int StartRowReadIndex = 2;

        public ExcelWorksheetReader(ExcelWorksheet excelWorksheet, TEntityWorksheet entityWorksheet)
            : base(entityWorksheet)
        {
            ExcelWorksheet = excelWorksheet;
            worksheetColumnsCount = entityWorksheet.Cells.Count();
        }

        protected void ValidateFirstRowForHeader()
        {
            var headerValues = ExcelWorksheet.GetValuesByRowNumber(1, 1, worksheetColumnsCount);
            var headerColumns = EntityWorksheet.Cells.Select(x => x.Field).ToList();

            if(!headerColumns.SequenceEqual(headerValues));
            {
                //throw new IncorrectHeaderException(headerColumns);
            }
        }

        public override List<TEntity> Read()
        {
            int rowNumber = StartRowReadIndex; 
            ValidateFirstRowForHeader();

            List<TEntity> entities = new List<TEntity>();
            string[] values = GetEntityRow(rowNumber);
            
            while (!IsLastRow(values))
            {
                entities.Add(EntityWorksheet.MapToEntity(values));
                rowNumber++;
                values = GetEntityRow(rowNumber);
            }

            return entities;
        }

        private string[] GetEntityRow(int rowNumber)
        {
            return ExcelWorksheet.GetValuesByRowNumber(rowNumber, 1, worksheetColumnsCount).ToArray();
        }

        private bool IsLastRow(IEnumerable<string> values)
        {
            return values.All(string.IsNullOrEmpty);
        }
    }
}