using System;
using System.Collections.Generic;
using System.Linq;
using Bussines.Mappings;
using Bussines.ViewModels.FurnitureModel;
using Domain;

namespace Bussines.Services
{
    public class ClientService : BaseService
    {
        public FurnitureModelsViewModel RandomModels(int count)
        {
            List<int> existingIds = UnitOfWork.FurnitureModelRepository.Get().Select(model => model.FurnitureModelId).ToList();
            List<int> selectedIds = new List<int>();
            
            if(count > existingIds.Count)
            {
                throw new ArgumentException("");
            }

            for (int i = 0; i < count; i++)
            {
                int selectedId = existingIds[new Random().Next(existingIds.Count)];
                selectedIds.Add(selectedId);
                existingIds.Remove(selectedId);
            }

            var models = UnitOfWork.FurnitureModelRepository.Get().Where(model => selectedIds.Contains(model.FurnitureModelId)).ToList();
            FurnitureModelsViewModel furnitureModels = new FurnitureModelsViewModel();
     
            foreach (FurnitureModel model in models)
            {
                furnitureModels.FurnitureModels
                    .Add(FurnitureModelMappings.MapToShortFurnitureModelViewModel(model));
            }

            UnitOfWork.Dispose();

            return furnitureModels;
        }
    }
}