namespace Xena.Contracts.ApiRoutes
{
    public class TermsHandlingRoutes : BaseRoutes
    {
        /// <summary>"XenaTerms"</summary>
        public const string Base = "XenaTerms";

        /// <summary>"{cultureId}/Reject"</summary>
        public const string PutReject = "{id}/Reject";

        /// <summary>"Unhandled"</summary>
        public const string GetUnhandledTerms = "Unhandled";
    }
}