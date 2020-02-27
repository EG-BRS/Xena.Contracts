namespace Xena.Contracts.ApiRoutes
{
    public class BlobFiscalRoutes
    {
        /// <summary>"Blob/Fiscal/{fiscalId}"</summary>
        public const string Base = "Blob/Fiscal/{fiscalId}";

        /// <summary>""</summary>
        public const string Post = "";

        /// <summary>"{relationType}/{relationId}"</summary>
        public const string PostByType = "{relationType}/{relationId}/{documentFolderId?}";

        /// <summary>"FromUrl"</summary>
        public const string PostFromUrl = "FromUrl";

        /// <summary>"FromUrl/{relationType}/{relationId}"</summary>
        public const string PostFromUrlByType = "FromUrl/{relationType}/{relationId}";

        /// <summary>"Download/{versionId}"</summary>
        public const string GetDownload = "Download/{versionId}";

        /// <summary>"{id}/Download"</summary>
        public const string GetDownloadByDocument = "{id}/Download";

        /// <summary>"{id}/Inline"</summary>
        public const string GetInlineByDocument = "{id}/Inline";

        /// <summary>"Inline/{versionId}"</summary>
        public const string GetInline = "Inline/{versionId}";

        /// <summary>"XmlConverted/{versionId}"</summary>
        public const string GetXmlConverted = "XmlConverted/{versionId}";

        /// <summary>"ThumbnailByDocument/{documentId}"</summary>
        public const string GetThumbnailByDocument = "ThumbnailByDocument/{documentId}";

        /// <summary>"Picture/{id}"</summary>
        public const string GetPicture = "Picture/{id}";

        /// <summary>"ScaledImage/{documentVersionId}"</summary>
        public const string GetScaledImage = "ScaledImage/{documentVersionId}";
    }
}