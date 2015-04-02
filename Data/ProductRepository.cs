using System;
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
            ApplicationContext.AddProductToWarehouse(furnitureModelId, assemblyDate);
        }
    }
}