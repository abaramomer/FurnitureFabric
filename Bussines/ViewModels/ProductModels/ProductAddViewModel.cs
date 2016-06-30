using System;
using System.Web.Mvc;

namespace Business.ViewModels.ProductModels
{
    public class ProductAddViewModel
    {
        public int FurnitureModelId { get; set; }

        public SelectList FurnitureModels { get; set; }

        public DateTime AssemblyDate { get; set; }
    }
}