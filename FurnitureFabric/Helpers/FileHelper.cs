using System.Configuration;
using System.IO;
using System.Web;

namespace FurnitureFabric.Helpers
{
    public class FileHelper
    {
        private const string ImageFormat = "png";

        public static string FurnitureModelImagePath = ConfigurationManager.AppSettings["FurnitureModelImagePath"];

        public static string SaveFurnitureImage(int id, HttpPostedFileBase image, HttpServerUtilityBase server)
        {
            string imagePath = string.Format("{0}/{1}.{2}", FurnitureModelImagePath, id, ImageFormat);

            return SaveAs(server, image, imagePath);
        }

        public static string SaveExcelFile(HttpPostedFileBase file, HttpServerUtilityBase server)
        {
            string localPath = string.Format("{0}/{1}", "/Excel", file.FileName);

            return SaveAs(server, file, localPath);
        }

        public static void DeleteFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            fileInfo.Delete();
        }

        private static string SaveAs(HttpServerUtilityBase serverUtility, HttpPostedFileBase file, string localPath)
        {
            var path = serverUtility.MapPath(localPath);
            file.SaveAs(path);

            return path;
        }
    }
}