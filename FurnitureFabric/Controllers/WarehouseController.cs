using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Business.Extensions;
using Business.Services;
using Business.ViewModels.FurnitureModel;
using Business.ViewModels.ProductModels;
using FurnitureFabric.ClientViewModels;
using FurnitureFabric.Helpers;

namespace FurnitureFabric.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly ProductService productService;
        private readonly FurnitureModelService furnitureModelService;

        public WarehouseController()
        {
            furnitureModelService = new FurnitureModelService();
            productService = new ProductService();
        }

        public ActionResult Index()
        {
            WarehouseMenuViewModel warehouseMenuViewModel = new WarehouseMenuViewModel();
            return View(warehouseMenuViewModel);
        }

        public ActionResult AddProduct()
        {
            var viewModel = productService.GetAddViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddProduct(ProductAddViewModel viewModel)
        {
            var model = productService.SaveProduct(viewModel);

            return RedirectToAction("ProductAdded", model);
        }
        public ActionResult AddFurnitureModel()
        {
            var model = furnitureModelService.GetAddViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddFurnitureModel(FurnitureAddViewModel viewModel, HttpPostedFileBase image)
        {
            var id = furnitureModelService.SaveFurniture(viewModel);
            if (image.IsNotNull())
            {
                FileHelper.SaveFurnitureImage(id, image, Server);
            }

            return Redirect("/Warehouse/FurnitureModelShow/" + id);
        }


        public ActionResult FurnitureModelShow(int id)
        {
            var model = furnitureModelService.GetFullModel(id);

            return View(model);
        }

        public ActionResult ModelList()
        {
            var model = furnitureModelService.GetAll();

            return View(model);
        }

        public ActionResult ProductAdded(ProductListItemViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}