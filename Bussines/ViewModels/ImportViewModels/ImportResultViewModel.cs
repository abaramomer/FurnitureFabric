using Business.ViewModels.ImportViewModels;

namespace Business.ViewModels.ImportViewModels
{
    public class ImportResultViewModel
    {
        public ImportResult ImportResult { get; set; }

        public int EntitiesCount { get; set; }

        public string ErrorMessage { get; set; }

        public string FormattedInfoMessage
        {
            get
            {
                if (ImportResult == ImportResult.Success)
                {
                    return string.Format("{0} entities was imported", EntitiesCount);
                }

                return ErrorMessage;
            }

        }
    }
}