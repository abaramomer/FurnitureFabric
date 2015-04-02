using Domain;

namespace Data
{
    public class UnitOfWork
    {
        private readonly FurnitureFabricEntities context;

        public ProductRepository ProductRepository { get; private set; }

        public IRepository<FurnitureModel> FurnitureModelRepository { get; private set; }

        public IRepository<FurnitureType> FurnitureTypeRepository { get; private set; }

        public IRepository<Material> MaterialRepository { get; private set; }

        public IRepository<Room> RoomRepository { get; private set; }

        public IRepository<Sale> SaleRepository { get; private set; }

        public UnitOfWork()
        {
            context = new FurnitureFabricEntities();
            ProductRepository = new ProductRepository(context);
            FurnitureModelRepository = new Repository<FurnitureModel>(context);
            FurnitureTypeRepository = new Repository<FurnitureType>(context);
            MaterialRepository = new Repository<Material>(context);
            RoomRepository = new Repository<Room>(context);
            SaleRepository = new Repository<Sale>(context);

        }

        public void Commit()
        {
            context.SaveChanges();
            
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
