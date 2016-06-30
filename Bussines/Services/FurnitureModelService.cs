using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Business.Mappings;
using Business.ViewModels.FurnitureModel;
using Domain;

namespace Business.Services
{
    public class FurnitureModelService : BaseService
    {
        public FullFurnitureViewModel GetFullModel(int id)
        {
            var entity = UnitOfWork.FurnitureModelRepository.Get().First(x => x.FurnitureModelId == id);
            
            var model = FurnitureModelMappings.MapToFullFurnitureViewModel(entity);
            UnitOfWork.Dispose();
            return model;
        }

        public FurnitureModelsViewModel GetAll()
        {
            var models = UnitOfWork.FurnitureModelRepository.Get().ToList();
            FurnitureModelsViewModel furnitureViewModels = new FurnitureModelsViewModel();
            foreach (var model in models)
            {
                furnitureViewModels.FurnitureModels.Add(FurnitureModelMappings.MapToShortFurnitureModelViewModel(model));
            }

            UnitOfWork.Dispose();
            return furnitureViewModels;
        }

        public FurnitureAddViewModel GetAddViewModel()
        {
            FurnitureAddViewModel model = new FurnitureAddViewModel();
            var rooms = UnitOfWork.RoomRepository.Get().ToList();
            var materials = UnitOfWork.MaterialRepository.Get().ToList();
            var types = UnitOfWork.FurnitureTypeRepository.Get().ToList();
            FillMaterials(model, materials);
            FillRooms(model, rooms);
            FillTypes(model, types);
            UnitOfWork.Dispose();

            return model;
        }

        public int SaveFurniture(FurnitureAddViewModel viewModel)
        {
            FurnitureModel entity = FurnitureModelMappings.MapFromAddFurnitureViewModel(viewModel);
            foreach (int materialId in viewModel.SelectedMaterials)
            {
                entity.Materials.Add(UnitOfWork.MaterialRepository.Get().First(x => x.MaterialId == materialId));
            }

            entity = UnitOfWork.FurnitureModelRepository.InsertOrUpdate(entity);

            UnitOfWork.Commit();
            UnitOfWork.Dispose();

            return entity.FurnitureModelId;
        }

        private void FillMaterials(FurnitureAddViewModel viewModel, List<Material> materials)
        {
            var items = new List<SelectListItem>();

            foreach (var material in materials)
            {
                items.Add(new SelectListItem
                {
                    Text = material.MaterialName,
                    Value = material.MaterialId.ToString()
                });
            }

            viewModel.Materials = new MultiSelectList(items, "Value", "Text");
        }

        private void FillRooms(FurnitureAddViewModel viewModel, List<Room> rooms)
        {
            var items = new List<SelectListItem>();

            foreach (var room in rooms)
            {
                items.Add(new SelectListItem
                {
                    Text = room.RoomName,
                    Value = room.RoomId.ToString()
                });
            }

            viewModel.Rooms = new SelectList(items, "Value", "Text");
        }

        private void FillTypes(FurnitureAddViewModel viewModel, List<FurnitureType> types)
        {
            var items = new List<SelectListItem>();

            foreach (var type in types)
            {
                items.Add(new SelectListItem
                {
                    Text = type.Type,
                    Value = type.TypeId.ToString()
                });
            }

            viewModel.Types = new SelectList(items, "Value", "Text");
        }
    }
}