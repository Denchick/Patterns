namespace Xrm.ReportUtility.Interfaces
{
    public interface IReportBuilder
    {
        string BuildHeader();
        string BuildBody();
        string BuildFooter();
    }
}