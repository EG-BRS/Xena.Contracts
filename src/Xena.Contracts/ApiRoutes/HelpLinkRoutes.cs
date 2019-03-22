namespace Xena.Contracts.ApiRoutes
{
    public class HelpLinkRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/HelpLink"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/HelpLink";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Help/{id}/HelpLink"</summary>
        public const string GetByHelp = "~/Api/Fiscal/{fiscalId}/Help/{id}/HelpLink";
    }
}