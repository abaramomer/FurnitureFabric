using System.Collections.Generic;
using Business.ViewModels.FurnitureModel;
using Domain;

namespace Business.Mappings
{
    public class FurnitureModelMappings
    {
        public static ShortFurnitureModelViewModel MapToShortFurnitureModelViewModel(FurnitureModel furnitureModel)
        {
            return new ShortFurnitureModelViewModel
            {
                Name = furnitureModel.Name,
                ModelId = furnitureModel.FurnitureModelId
            };
        }
    }
}