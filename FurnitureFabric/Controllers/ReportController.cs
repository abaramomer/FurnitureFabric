using System.Web.Mvc;
using Business.Services;
using FurnitureFabric.Helpers;

namespace FurnitureFabric.Controllers
{
    public class ReportController : Controller
    {
        private readonly ReportService reportService;
        public ReportController()
        {
            reportService = new ReportService();
        }

        public ActionResult Index(int? id)
        {
            var viewModel = reportService.GetReport(id);

            if (viewModel.ShowReport)
            {
                ViewData["Report"] = ReportViewerHelper.GetReportViewer(viewModel.CurrentReport);
            }

            return View(viewModel);
        }
    }
}