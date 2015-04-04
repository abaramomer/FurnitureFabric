using System.Web.Mvc;
using Bussines.Services;

namespace FurnitureFabric.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientService clientService;
        public ClientController()
        {
            clientService = new ClientService();
        }

        public ActionResult Index()
        {
            var model = clientService.RandomModels(3);
            return View(model);
        }
    }
}