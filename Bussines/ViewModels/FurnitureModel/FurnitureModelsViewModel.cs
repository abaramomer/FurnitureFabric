using System.Collections.Generic;

namespace Bussines.ViewModels.FurnitureModel
{
    public class FurnitureModelsViewModel
    {
        public FurnitureModelsViewModel()
        {
            FurnitureModels = new List<ShortFurnitureModelViewModel>();
        }

        public List<ShortFurnitureModelViewModel> FurnitureModels { get; set; } 
    }
}