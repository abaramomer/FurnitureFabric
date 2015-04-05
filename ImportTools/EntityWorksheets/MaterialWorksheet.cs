using Domain;

namespace ImportTools.EntityWorksheets
{
    internal class MaterialWorksheet : BaseEntityWorksheet<Material>
    {
        public MaterialWorksheet()
        {
            Cells = new[]
            {
                new EntityCell("Material")
            };
        }

        public override Material MapToEntity(string[] cellValues)
        {
            return new Material
            {
                MaterialName = cellValues[0]
            };
        }
    }
}