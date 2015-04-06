using System.Collections.Generic;

namespace Business.ViewModels.ReportViewModels
{
    public class ReportViewModel
    {
        public ReportViewModel()
        {
            ReportList = new List<ReportItemViewModel>();
        }

        public List<ReportItemViewModel> ReportList { get; set; }

        public string CurrentReport { get; set; }

        public bool ShowReport { get; set; }
    }
}