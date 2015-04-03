using System.Collections.Generic;
using System.Linq;

namespace Bussines.Services
{
    public class ProductService : BaseService
    {
        public ProductService()
        {
            
        }

        public List<string> GetAllProducts()
        {
            var y = UnitOfWork.SaleRepository.Get().Where(yy => yy.Cost > 0);
            var x = UnitOfWork.FurnitureModelRepository.Get().Where(zz => zz.TypeId != null).First();
            var xx = x.Colors.First();
            UnitOfWork.Commit();

            return null;
        }
    }
}