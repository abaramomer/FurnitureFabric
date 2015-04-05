using System.Collections.Generic;

namespace Business.ViewModels.FurnitureModel
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