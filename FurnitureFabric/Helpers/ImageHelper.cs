using System.Configuration;
using System.Web;

namespace FurnitureFabric.Helpers
{
    public class ImageHelper
    {
        private static string imageFormat = "png";

        public static string FurnitureModelImagePath = ConfigurationManager.AppSettings["FurnitureModelImagePath"];

        public static void Save(int id, HttpPostedFileBase image, HttpServerUtilityBase server)
        {
            string imagePath = string.Format("{0}/{1}.{2}", FurnitureModelImagePath, id, imageFormat);
            image.SaveAs(server.MapPath(imagePath));
        }
    }
}