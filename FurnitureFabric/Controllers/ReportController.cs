using System.Data;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;

namespace FurnitureFabric.Controllers
{
    public class ReportController : Controller
    {
        public ActionResult Index()
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;

            reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\ReportTemplates\Report.rdlc";
            ReportDataSource dataSource = new ReportDataSource("Report");
            reportViewer.LocalReport.DataSources.Add(dataSource);
            ViewBag.ReportViewer = reportViewer;
            return View();
        }
    }
}