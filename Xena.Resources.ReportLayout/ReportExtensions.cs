using System.Globalization;

namespace Xena.Resources
{
    public static class ReportExtensions
    {
        public static string GetLocalizedReportXSLT(this string reportGroup, CultureInfo currentCulture)
        {
            var lookup = string.Format("Xena_Reports_DefaultXSLT_{0}", reportGroup);
            return Files.ResourceManager.GetString(lookup, currentCulture);
        }
    }
}