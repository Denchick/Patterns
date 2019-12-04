using System;
using System.Collections.Generic;
using System.Linq;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility
{
    public class ReportBuilder: IReportBuilder
    {
        private readonly Report _report;

        public ReportBuilder(Report report)
        {
            _report = report;
        }

        public string BuildHeader()
        {
            var result = "Наименование\tОбъём упаковки\tМасса упаковки\tСтоимость\tКоличество";
            if (_report.Config.WithIndex)
                result = "№\t" + result;
            if (_report.Config.WithTotalVolume)
                result = result + "\tСуммарный объём";
            if (_report.Config.WithTotalWeight)
                result = result + "\tСуммарный вес";

            return result;
        }
        
        public string BuildBody()
        {
            var rowTemplate = BuildRowTemplate(_report.Config);
            var rows = _report.Data.Select((row, i) => BuildRow(row, i, rowTemplate));
            return string.Join(Environment.NewLine, rows);
        }

        public string BuildFooter()
        {
            var result = new List<string> {"Итого"};
            result.AddRange(_report.Rows.Select(row => $"  {row.Name,-20}\t{row.Value}"));
            return string.Join(Environment.NewLine, result);
        }
        
        private string BuildRow(DataRow row, int rowIndex, string rowTemplate) =>
            string.Format(rowTemplate, rowIndex + 1, row.Name, row.Volume, row.Weight, row.Cost, row.Count,
                row.Volume * row.Count, row.Weight * row.Count);
        
        private string BuildRowTemplate(ReportConfig config)
        {
            var rowTemplate = "{1,12}\t{2,14}\t{3,14}\t{4,9}\t{5,10}";
            if (config.WithIndex)
                rowTemplate = "{0}\t" + rowTemplate;
            if (config.WithTotalVolume)
                rowTemplate = rowTemplate + "\t{6,15}";
            if (config.WithTotalWeight)
                rowTemplate = rowTemplate + "\t{7,13}";

            return rowTemplate;
        }
    }
}