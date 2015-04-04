using System.Collections.Generic;
using Bussines.ViewModels.FurnitureModel;
using Domain;

namespace Bussines.Mappings
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