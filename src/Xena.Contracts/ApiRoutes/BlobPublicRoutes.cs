namespace Xena.Contracts.ApiRoutes
{
    public class BlobPublicRoutes
    {
        /// <summary>"Blob/Public"</summary>
        public const string Base = "Blob/Public";

        /// <summary>"VCard/{id}/Thumbnail"</summary>
        public const string GetThumbnailByVCard = "VCard/{id}/Thumbnail";

        /// <summary>"VCard/{id}/Thumbnail/{vi}"</summary>
        public const string GetThumbnailByVCardCache = "VCard/{id}/Thumbnail/{vi}";

        /// <summary>"XenaApp/{id}/Thumbnail"</summary>
        public const string GetThumbnailByXenaApp = "XenaApp/{id}/Thumbnail";

        /// <summary>"XenaTempApp/{id}/Thumbnail"</summary>
        public const string GetThumbnailByXenaTempApp = "XenaTempApp/{id}/Thumbnail";

    }
}