namespace Xena.Contracts.ApiRoutes
{
    public class BlobUserRoutes
    {
        /// <summary>"Blob"</summary>
        public const string Base = "Blob/User";

        /// <summary>""</summary>
        public const string Post = "";

        /// <summary>"Document/FromUrl"</summary>
        public const string PostFromUrl = "Document/FromUrl";

        /// <summary>"Download/{versionId}"</summary>
        public const string GetDownload = "Download/{versionId}";

        /// <summary>"Inline/{versionId}"</summary>
        public const string GetInline = "Inline/{versionId}";

        /// <summary>"ThumbnailByDocument/{documentId}"</summary>
        public const string GetThumbnailByDocument = "ThumbnailByDocument/{documentId}";

        /// <summary>"Picture/{id}"</summary>
        public const string GetPicture = "Picture/{id}";

        /// <summary>"UserVCardImage"</summary>
        public const string GetUserVCardImage = "UserVCardImage";

        /// <summary>"ScaledImage/{documentVersionId}"</summary>
        public const string GetScaledImage = "ScaledImage/{documentVersionId}";
    }
}