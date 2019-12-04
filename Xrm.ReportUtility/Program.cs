using System;
using System.Linq;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;
using Xrm.ReportUtility.Services;

namespace Xrm.ReportUtility
{
    public static class Program
    {
        // "Files/table.txt" -data -weightSum -costSum -withIndex -withTotalVolume
        public static void Main(string[] args)
        {
            var config = ParseConfig(args);
            var service = GetReportService(config.Filename);
            // Мы принимаем таблицы в форматах (csv, xlsx, txt) и хотим строить табличку в txt.
            // Поэтому данные исходных таблиц преобразуются в объект-прослойку и по нему строится итоговая табличка в txt.
            // Адаптер
            var report = service.CreateReport(config);
            var stringReport = service.Build(report);
            Console.WriteLine(stringReport);

            Console.WriteLine("");
            Console.WriteLine("Press enter...");
            Console.ReadLine();
        }

        // Приложение создаёт определённую фабрику(IReportService) в зависимости от расширения файла.
        // Фабричный метод
        private static IReportService GetReportService(string filename)
        {
            if (filename.EndsWith(".txt"))
            {
                return new TxtReportService();
            }

            if (filename.EndsWith(".csv"))
            {
                return new CsvReportService();
            }

            if (filename.EndsWith(".xlsx"))
            {
                return new XlsxReportService();
            }

            throw new NotSupportedException("this extension not supported");
        }

        private static ReportConfig ParseConfig(string[] args)
        {
            return new ReportConfig
            {
                Filename = args[0],
                
                WithData = args.Contains("-data"),
                WithIndex = args.Contains("-withIndex"),
                WithTotalVolume = args.Contains("-withTotalVolume"),
                WithTotalWeight = args.Contains("-withTotalWeight"),

                VolumeSum = args.Contains("-volumeSum"),
                WeightSum = args.Contains("-weightSum"),
                CostSum = args.Contains("-costSum"),
                CountSum = args.Contains("-countSum")
            };
        }
    }
}