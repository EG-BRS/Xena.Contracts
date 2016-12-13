using System;
using System.IO;
using System.Linq;

namespace Xena.Contracts.Domain
{
    public class DocumentVersionDto : IHasIdDto
    {
        public string FileName { get; set; }
        public DateTime Created { get; set; }
        public string Note { get; set; }
        public long? Id { get; set; }
        public string ContentType { get; set; }
        public bool? HasPreview { get;set; }
        public int? PreviewPages { get;set; }
        public int? PageCount { get; set; }
        public bool IsInline
        {
            get
            {
                if (ContentType == null)
                    return false;

                switch (ContentType.ToLower())
                {
                    case ("application/pdf"):
                    case ("image/jpeg"):
                    case ("image/pjpeg"):
                    case ("image/bmp"):
                    case ("image/gif"):
                    case ("image/png"):
                    {
                        return true;
                    }
                    default:
                    {
                        return false;
                    }
                }
            }
        }



        public bool IsImage
        {
            get
            {
                switch (GetExtension(FileName))
                {
                    case (".jpg"):
                    case (".pjpeg"):
                    case (".jpeg"):
                    case (".bmp"):
                    case (".gif"):
                    case (".png"):
                        {
                            return true;
                        }
                    default:
                        {
                            return false;
                        }
                }
            }
        }

        public bool IsPdf => GetExtension(FileName).Equals(".pdf", StringComparison.OrdinalIgnoreCase);

        private static string GetExtension(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                return "";
            filename = Path.GetInvalidFileNameChars().Aggregate(filename, (current, c) => current.Replace(c.ToString(), ""));
            return Path.GetExtension(filename)?.ToLowerInvariant() ?? "";
        }

    }
}