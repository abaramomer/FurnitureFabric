using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using Business.ViewModels.ImportViewModels;
using Data;
using Domain;
using ImportTools;
using ImportTools.Exceptions;

namespace Business.Services
{
    public class ImportService : BaseService
    {
        private readonly Dictionary<int, Type> entityImportMapping = new Dictionary<int, Type>
        {
            {0, typeof(FurnitureModel)},
            {1, typeof(Product)},
            {2, typeof(Material)}
        };

        public ImportViewModel GetViewModel()
        {
            ImportViewModel viewModel = new ImportViewModel();
            FillSupportedImportedEnteties(viewModel);

            UnitOfWork.Dispose();
            return viewModel;
        }

        public void ExcelImport(ImportViewModel viewModel)
        {
            var fileInfo = new FileInfo(viewModel.FilePath);
            var excelImportService = new ExcelImportService();
            
            Type entityType = entityImportMapping[viewModel.SelectedEntity];
            try
            {
                var importedEntities = excelImportService.Import(fileInfo, entityType);
                SaveImportedEntities(importedEntities, entityType);

                UnitOfWork.Commit();

                viewModel.ImportResultViewModel = new ImportResultViewModel
                {
                    ImportResult = ImportResult.Success,
                    EntitiesCount = importedEntities.Count
                };
            }

            catch (ImportToolException e)
            {
                viewModel.ImportResultViewModel = new ImportResultViewModel
                {
                    ImportResult = ImportResult.Fail,
                    ErrorMessage = e.ImportToolExceptionMessage
                };
            }

            finally
            {
                UnitOfWork.Dispose();
                FillSupportedImportedEnteties(viewModel);
            }
        }

        //this is realy ugly... but i don't have any time to create it better
        //TODO: create dictionary in unitofwork to get a repositoty by entity type
        private void SaveImportedEntities(IEnumerable<Entity> entities, Type entityType)
        {
            if (entityType == typeof (FurnitureModel))
            {
                SaveEntityList(entities, UnitOfWork.FurnitureModelRepository);
                return;
            }

            if (entityType == typeof(Material))
            {
                SaveEntityList(entities, UnitOfWork.MaterialRepository);
                return;
            }
        }

        private void SaveEntityList<T>(IEnumerable<Entity> entities, IRepository<T> repository) where T : Entity
        {
            foreach (Entity entity in entities)
            {
                var savedEntity = (T) entity;
                repository.InsertOrUpdate(savedEntity);
            }
        }

        private void FillSupportedImportedEnteties(ImportViewModel viewModel)
        {
            var items = new List<SelectListItem>();

            foreach (var entityImport in entityImportMapping)
            {
                items.Add(new SelectListItem()
                {
                    Text = entityImport.Value.Name,
                    Value = entityImport.Key.ToString()
                });
            }
                
            viewModel.ImportedEntities = new SelectList(items, "Value", "Text");
        }
    }
}