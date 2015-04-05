using System.Web.Mvc;

namespace Business.ViewModels.ImportViewModels
{
    public class ImportViewModel
    {
        public SelectList ImportedEntities { get; set; }

        public int SelectedEntity { get; set; }

        public string FilePath { get; set; }

        public ImportResultViewModel ImportResultViewModel { get; set; }
    }
}