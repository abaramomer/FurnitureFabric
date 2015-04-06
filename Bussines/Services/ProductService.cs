using System;
using System.Collections.Generic;
using System.Linq;
using Business.Extensions;
using Business.Mappings;
using Business.ViewModels.ProductModels;
using Domain;

namespace Business.Services
{
    public class ProductService : BaseService
    {
        public ProductGridViewModel GetAllProducts(ProductFilterViewModel filterViewModel)
        {
            var products =
                UnitOfWork.ProductRepository.Get().Where(x => x.FurnitureModelId == filterViewModel.FurnitureModelId);
            var gridViewModel = new ProductGridViewModel();
            foreach (var product in products)
            {
                gridViewModel.ListItems.Add(ProductMappings.MapProductListToProductListItemViewModel(product));
            }

            gridViewModel.FilterViewModel = filterViewModel;

            return gridViewModel;
        }
    }
}