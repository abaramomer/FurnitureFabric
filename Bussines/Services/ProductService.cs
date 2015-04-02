using System;
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
            var x = UnitOfWork.FurnitureModelRepository.Get().ToList();
            var xx = x.First().Color.First();
            UnitOfWork.Commit();

            return null;
        }
    }
}