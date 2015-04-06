using System.Collections.Generic;
using Business.ViewModels.ReportViewModels;

namespace Business.Services
{
    public class ReportService
    {
        private const string ReportFolder = "Reports";

        private readonly Dictionary<int, string> mapReportNameToId = 
            new Dictionary<int, string>
        {
            {1, "SalesProduct"}
        };

        public ReportViewModel GetReport(int? reportId)
        {
            ReportViewModel viewModel = new ReportViewModel();
            FillItems(viewModel);
            viewModel.ShowReport = reportId.HasValue;

            if(reportId.HasValue)
            {
                viewModel.CurrentReport = string.Format("/{0}/{1}", ReportFolder, mapReportNameToId[reportId.Value]);
            }

            return viewModel;
        }

        private void FillItems(ReportViewModel viewModel)
        {
            foreach (var reportMap in mapReportNameToId)
            {
                viewModel.ReportList.Add(new ReportItemViewModel
                {
                    ReportId = reportMap.Key,
                    ReportName = reportMap.Value
                });
            }
        }
    }
}