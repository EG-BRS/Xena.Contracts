namespace Xena.Contracts.ApiRoutes
{
    public class HelpLinkRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/HelpLink"</summary>
        public const string Base = "Fiscal/{fiscalId}/HelpLink";

        /// <summary>"~/Fiscal/{fiscalId}/Help/{id}/HelpLink"</summary>
        public const string GetByHelp = "~/Fiscal/{fiscalId}/Help/{id}/HelpLink";
    }
}