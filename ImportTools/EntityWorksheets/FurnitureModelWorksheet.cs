using System;
using Domain;

namespace ImportTools.EntityWorksheets
{
    internal class FurnitureModelWorksheet : BaseEntityWorksheet<FurnitureModel>, IExcelWorksheetReader
    {
        public FurnitureModelWorksheet()
        {
            Cells = new[]
            {
                new EntityCell("Name"),
                new EntityCell("TypeId", true),
                new EntityCell("AdditionalInfo", true),
                new EntityCell("RoomId", true)
            };
        }

        public override FurnitureModel MapToEntity(string[] cellValues)
        {
            return new FurnitureModel
            {
                Name = cellValues[0],
                TypeId = string.IsNullOrEmpty(cellValues[1]) ? new int?() : Convert.ToInt32(cellValues[1]),
                AdditionalInfo = cellValues[2],
                RoomId = string.IsNullOrEmpty(cellValues[3]) ? new int?() : Convert.ToInt32(cellValues[3])
            };
        }
    }
}