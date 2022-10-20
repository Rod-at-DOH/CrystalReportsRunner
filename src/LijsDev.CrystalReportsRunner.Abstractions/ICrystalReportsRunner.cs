namespace LijsDev.CrystalReportsRunner.Abstractions;

/// <summary>
/// Crystal Reports Runner interface
/// </summary>
public interface ICrystalReportsRunner
{
    /// <summary>
    /// Show report in modeless window
    /// </summary>
    void ShowReport(
        Report report,
        ReportViewerSettings viewerSettings,
        WindowHandle? owner = null,
        DbConnection? connection = null);

    /// <summary>
    /// Show report in modal window
    /// </summary>
    void ShowReportDialog(
        Report report,
        ReportViewerSettings viewSettings,
        WindowHandle owner,
        DbConnection? connection);
}

/// <summary>
/// Crystal Reports Caller interface
/// </summary>
public interface ICrystalReportsCaller { }

/// <summary>
/// Default Crystal Reports Caller implementation
/// </summary>
public class DefaultCrystalReportsCaller : ICrystalReportsCaller { }
