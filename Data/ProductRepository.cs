using System;
using System.Data.Objects;
using System.Linq;
using Domain;

namespace Data
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(FurnitureFabricEntities context) : base(context)
        {
        }

        public void AddProductToWarehouse(int furnitureModelId, DateTime assemblyDate)
        {
            Context.AddProductToWarehouse(furnitureModelId, assemblyDate);
        }

        public IQueryable<Product> GetProducts(int furnitureModelId, DateTime assemblyDate, int? productStatusId)
        {
            return null; // Context.GetProducts(furnitureModelId, assemblyDate, productStatusId);
        }
    }
}