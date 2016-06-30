using System.Collections.Generic;
using Domain;

namespace Business.ViewModels.FurnitureModel
{
    public class FullFurnitureViewModel
    {
        public FullFurnitureViewModel()
        {
            Materials = new List<string>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string AdditionalInfo { get; set; }

        public List<string> Materials { get; set; }

        public string Room { get; set; }

        public string Type { get; set; }

        public int ProductsCount { get; set; }
    }
}