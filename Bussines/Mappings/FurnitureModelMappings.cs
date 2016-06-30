using System.Collections.Generic;
using System.Linq;
using Business.Extensions;
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

        public static FurnitureModel MapFromAddFurnitureViewModel(FurnitureAddViewModel viewModel)
        {
            return new FurnitureModel
            {
                Name = viewModel.Name,
                AdditionalInfo = viewModel.AdditionalInfo,
                Colors = null,
                TypeId = viewModel.SelectedType,
                RoomId = viewModel.SelectedRoom
            };
        }

        public static FullFurnitureViewModel MapToFullFurnitureViewModel(FurnitureModel model)
        {
            var viewModel = new FullFurnitureViewModel
            {
                Id = model.FurnitureModelId,
                AdditionalInfo = model.AdditionalInfo,
                Name = model.Name,
                Room = model.Room.IsNotNull() ? model.Room.RoomName : null,
                Type = model.FurnitureType.IsNotNull() ? model.FurnitureType.Type : null,
                ProductsCount = model.Products.IsNotNull() ? model.Products.Count : 0
            };
            
            if (model.Materials.IsNotNull())
            {
                viewModel.Materials = model.Materials.Select(x => x.MaterialName).ToList();
            }

            return viewModel;
        }
    }
}