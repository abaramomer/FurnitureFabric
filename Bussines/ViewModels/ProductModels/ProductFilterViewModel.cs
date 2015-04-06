using System;
using Domain;

namespace Business.ViewModels.ProductModels
{
    public class ProductFilterViewModel
    {
        public int FurnitureModelId { get; set; }

        public DateTime AssemblyDateTime { get; set; }

        public int StatusId { get; set; }
    }
}