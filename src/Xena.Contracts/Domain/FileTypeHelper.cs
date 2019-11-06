using System;
using System.IO;
using System.Linq;
using Xena.Contracts.Domain.DocumentRelated;

namespace Xena.Contracts.Domain
{
    public static class FileTypeHelper
    {
        public static string[] ImageTypes => new[]
        {
            Jpg,
            Pjpeg,
            Jpeg,
            Bmp,
            Gif,
            Png
        };
        public static string[] PdfTypes => new[]
        {
            Pdf
        };

        private const string Jpg = "jpg";
        private const string Pjpeg = "pjpeg";
        private const string Jpeg = "jpeg";
        private const string Bmp = "bmp";
        private const string Gif = "gif";
        private const string Png = "png";
        private const string Pdf = "pdf";

        public static string[] LastContentTypes => new[]
        {
            ApplicationPdf, ImageJpeg, ImageJpg, ImagepJpeg, ImageBmp, ImageGif, ImagePng
        };

        private const string ApplicationPdf = "application/pdf";
        private const string ImageJpeg = "image/jpeg";
        private const string ImageJpg = "image/jpg";
        private const string ImagepJpeg = "image/pjpeg";
        private const string ImageBmp = "image/bmp";
        private const string ImageGif = "image/gif";
        private const string ImagePng = "image/png";

        private const string xml = "xml";

        public static string[] XMLTypes => new[]
        {
            xml
        };

        public static bool IsImage(this string fileName)
        {
            return (ImageTypes.FirstOrDefault(we => we.Equals(fileName.Replace(".", string.Empty), StringComparison.OrdinalIgnoreCase)) !=
                    null);
        }

        public static bool IsPdf(this string fileName)
        {
            return (PdfTypes.FirstOrDefault(we => we.Equals(fileName.Replace(".", string.Empty), StringComparison.OrdinalIgnoreCase)) !=
                    null);
        }

        public static bool IsXML(this string fileName)
        {
            return (XMLTypes.FirstOrDefault(we => we.Equals(fileName.Replace(".", string.Empty), StringComparison.OrdinalIgnoreCase)) !=
                    null);
        }

        public static bool IsInline(this DocumentDto doc)
        {
            if (doc.LastContentType == null) return false;
            return LastContentTypes.FirstOrDefault(we =>
                       we.Equals(doc.LastContentType.ToLowerInvariant(), StringComparison.OrdinalIgnoreCase)) != null;
        }

        public static string GetExtension(string filename)
        {
            if (string.IsNullOrEmpty(filename)) return "";

            filename = Path.GetInvalidFileNameChars().Aggregate(filename, (current, c) => current.Replace(c.ToString(), ""));

            return Path.GetExtension(filename)?.ToLowerInvariant() ?? "";
        }
    }
}
