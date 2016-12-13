using System;
using System.IO;
using System.Linq;

namespace Xena.Contracts.Domain
{
    public class DocumentDto:IHasIdDto
    {
        public long? Id { get; set; }
        public string LastFileName { get; set; }
        public int LastContentLength { get; set; }
        public DateTime LastCreated { get; set; }
        public long? LastVersionId { get; set; }
        public bool IsDeactivated { get; set; }
        public string Description { get; set; }
        public string LastContentType { get; set; }
        public string LastNote { get; set; }
        public int Version { get; set; }
        public string LastFileFolder { get; set; }
        public Guid LastFileId { get; set; }

        public bool IsInline
        {
            get
            {
                if (LastContentType == null) return false;

                switch (LastContentType.ToLower())
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

        public bool CompatibleWithZoho
        {
            get
            {
                switch (GetExtension(LastFileName))
                {
                    //Presentation
                    case (".pps"):
                    case (".ppt"):
                    case (".odp"):
                    case (".sxi"):
                    case (".tsv"):
                    case (".ods"):
                    case (".csv"):
                    case (".xls"):
                    case (".xlsx"):
                    case (".html"):
                    case (".sxw"):
                    case (".rtf"):
                    case (".odt"):
                    case (".txt"):
                    case (".doc"):
                    case (".docx"):
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
                switch (GetExtension(LastFileName))
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

        public bool IsInlinePdf
        {
            get
            {
                switch (GetExtension(LastFileName))
                {
                    case (".pdf"):
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

        private string GetExtension(string filename)
        {
            if (string.IsNullOrEmpty(filename)) return "";

            filename = Path.GetInvalidFileNameChars().Aggregate(filename, (current, c) => current.Replace(c.ToString(), ""));

            return Path.GetExtension(filename)?.ToLowerInvariant() ?? "";
        }
    }
}