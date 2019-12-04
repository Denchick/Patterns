using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xrm.ReportUtility.Infrastructure;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.Services
{
    public abstract class ReportServiceBase : IReportService
    {
        public Report CreateReport(ReportConfig config)
        {
            var dataTransformer = DataTransformerCreator.CreateTransformer(config);

            var text = File.ReadAllText(config.Filename);
            var data = GetDataRows(text);
            return dataTransformer.TransformData(data);
        }

        public string Build(Report report)
        {
            var result = new List<string>();
            var reportBuilder = new ReportBuilder(report);
            if (report.Config.WithData && report.Data != null && report.Data.Any())
            {
                result.Add(reportBuilder.BuildHeader());
                result.Add(reportBuilder.BuildBody());
                result.Add(Environment.NewLine);
            }

            if (report.Rows != null && report.Rows.Any())
            {
                result.Add(reportBuilder.BuildFooter());
            }

            return string.Join(Environment.NewLine, result);
        }

        protected abstract DataRow[] GetDataRows(string text);
    }
}
