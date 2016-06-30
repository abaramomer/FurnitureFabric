using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using Business.Extensions;
using Business.Mappings;
using Business.ViewModels.ProductModels;
using Data;
using Domain;

namespace Business.Services
{
    public class ProductService : BaseService
    {
        public ProductAddViewModel GetAddViewModel()
        {
            var furnitureModels = UnitOfWork.FurnitureModelRepository.Get().ToList();
            var viewModel = new ProductAddViewModel {AssemblyDate = DateTime.Now};
            FillFurnitureModels(viewModel, furnitureModels);

            UnitOfWork.Dispose();
            return viewModel;
        }

        public ProductListItemViewModel SaveProduct(ProductAddViewModel viewModel)
        {
            UnitOfWork.ProductRepository.AddProductToWarehouse(viewModel.FurnitureModelId, viewModel.AssemblyDate);
            UnitOfWork.Commit();

            var addedProduct = UnitOfWork.ProductRepository.Get()
                .FirstOrDefault(x => x.FurnitureModelId == viewModel.FurnitureModelId && x.AssemblyDate == viewModel.AssemblyDate);

            var returndeViewModel = ProductMappings.MapProductListToProductListItemViewModel(addedProduct);

            UnitOfWork.Dispose();

            return returndeViewModel;
        }

        private void FillFurnitureModels(ProductAddViewModel viewModel, List<FurnitureModel> furnitureModels)
        {
            var items = new List<SelectListItem>();

            foreach (var furnitureModel in furnitureModels)
            {
                items.Add(new SelectListItem
                {
                    Text = furnitureModel.Name,
                    Value = furnitureModel.FurnitureModelId.ToString()
                });
            }

            viewModel.FurnitureModels = new SelectList(items, "Value", "Text");
        }
    }
}