using System.Web;
using System.Web.Mvc;
using Business.Services;
using Business.ViewModels.ImportViewModels;
using FurnitureFabric.Helpers;

namespace FurnitureFabric.Controllers
{
    public class ImportController : Controller
    {
        private readonly ImportService importService;

        public ImportController()
        {
            importService = new ImportService();
        }

        public ActionResult Index()
        {
            var viewModel = importService.GetViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(ImportViewModel importViewModel, HttpPostedFileBase importedFile)
        {
            importViewModel.FilePath = FileHelper.SaveExcelFile(importedFile, Server);
            importService.ExcelImport(importViewModel);

            return View(importViewModel);
        }
    }
}