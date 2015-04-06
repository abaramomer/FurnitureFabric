using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Services;
using Business.ViewModels.ProductModels;

namespace FurnitureFabric.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly ProductService productService;

        public WarehouseController()
        {
            productService = new ProductService();
        }

        public ActionResult Index()
        {
            var viewModel = productService.GetAllProducts(new ProductFilterViewModel {FurnitureModelId = 1});
            return View();
        }
    }
}