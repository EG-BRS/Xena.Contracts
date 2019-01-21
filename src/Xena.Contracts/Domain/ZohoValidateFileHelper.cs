using System;
using System.IO;
using System.Linq;

namespace Xena.Contracts.Domain
{
    public static class ZohoValidateFileHelper
    {
        public static string[] DocumentTypes => new[]
        {
            Doc,
            Docx,
            Html,
            Pdf,
            Htm,
            Odt,
            Rtf,
            Txt
        };

        private const string Doc = "doc";
        private const string Docx = "docx";
        private const string Html = "html";
        private const string Pdf = "pdf";
        private const string Htm = "htm";
        private const string Odt = "odt";
        private const string Rtf = "rtf";
        private const string Txt = "txt";

        public static string[] SheetTypes => new[]
        {
            Xls,
            Xlsx,
            Ods,
            Sxc,
            Csv,
            Tsv
        };

        private const string Xls = "xls";
        private const string Xlsx = "xlsx";
        private const string Ods = "ods";
        private const string Sxc = "sxc";
        private const string Csv = "csv";
        private const string Tsv = "tsv";

        public static string[] SlideTypes => new[]
        {
            Ppt,
            Pptx,
            Pps,
            Ppsx,
            Odp,
            Sxi,
        };

        private const string Ppt = "ppt";
        private const string Pptx = "pptx";
        private const string Pps = "pps";
        private const string Ppsx = "ppsx";
        private const string Odp = "odp";
        private const string Sxi = "sxi";

        public static string[] ZohoDocumentType => new[]
        {
            Sheet, Document, Slide
        };

        private const string Sheet = "sheet";
        private const string Document = "document";
        private const string Slide = "slide";

        public static bool IsExtensionZohoDocument(string fileExtension)
        {
            return (DocumentTypes.FirstOrDefault(we => we.Equals(fileExtension, StringComparison.OrdinalIgnoreCase)) !=
                    null);
        }

        public static bool IsExtensionZohoSheet(string fileExtension)
        {
            return (SheetTypes.FirstOrDefault(we =>
                        we.Equals(fileExtension, StringComparison.OrdinalIgnoreCase)) != null);
        }
        public static bool IsExtensionZohoSlide(string fileExtension)
        {
            return SlideTypes.FirstOrDefault(we =>
                       we.Equals(fileExtension, StringComparison.OrdinalIgnoreCase)) != null;
        }

        public static string GetExtension(string filename)
        {
            if (string.IsNullOrEmpty(filename)) return "";

            filename = Path.GetInvalidFileNameChars().Aggregate(filename, (current, c) => current.Replace(c.ToString(), ""));

            return Path.GetExtension(filename)?.ToLowerInvariant() ?? "";
        }
    }
}
