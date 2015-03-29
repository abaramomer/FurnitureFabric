using System.Web.Mvc;

namespace FurnitureFabric.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}