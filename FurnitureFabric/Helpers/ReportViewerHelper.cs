using System;
using System.Configuration;
using System.Drawing;
using Microsoft.Reporting.WebForms;

namespace FurnitureFabric.Helpers
{
    public static class ReportViewerHelper
    {
        private const ProcessingMode ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
        private static readonly string ReportServerUrl = ConfigurationManager.AppSettings["ReportServerUrl"];
        private const int ReportWidth = 750;
        private static readonly Color BackColor = Color.WhiteSmoke;

        public static ReportViewer GetReportViewer(string reportPath)
        {
            ReportViewer reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode,
                BackColor = BackColor,
                Width = ReportWidth
            };

            reportViewer.ServerReport.ReportPath = reportPath;
            reportViewer.ServerReport.ReportServerUrl = new Uri(ReportServerUrl);

            return reportViewer;
        }
    }
}