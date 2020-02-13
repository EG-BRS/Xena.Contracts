namespace Xena.Contracts.ApiRoutes
{
    public class SupporterRoutes : BaseRoutes
    {
        /// <summary>"XenaApp/Supporter/</summary>
        public const string Base = "XenaAdmin/Supporter";

        /// <summary>"History"</summary>
        public const string GetHistoryList = "History";

        /// <summary>"{fiscalSetupId}/EnsureSupporterExists"</summary>
        public const string PostEnsureSupporterExists = "{fiscalSetupId}/EnsureSupporterExists";

        /// <summary>"~/XenaAdmin/FiscalSetup"</summary>
        public const string GetFiscalSetupList = "~/XenaAdmin/FiscalSetup";

        /// <summary>"~/XenaAdmin/ProviderFiscalSetup"</summary>
        public const string GetProviderFiscalSetupList = "~/XenaAdmin/ProviderFiscalSetup";

        /// <summary>"~/XenaAdmin/FiscalSetup/{id}/Membership"</summary>
        public const string GetFiscalSetupMembershipList = "~/XenaAdmin/FiscalSetup/{id}/Membership";

        /// <summary>"~/Fiscal/{fiscalSetupId}/LimitedFiscal"</summary>
        public const string GetLimitedFiscal = "FiscalSetup/{fiscalSetupId}/LimitedFiscal";

        /// <summary>"~/Fiscal/{fiscalSetupId}/LimitedFiscal"</summary>
        public const string PostLimitedFiscal = "FiscalSetup/{fiscalSetupId}/LimitedFiscal";

        /// <summary> "~/LimitedFiscal/{limitedFiscalId}" </summary>
        public const string DeleteLimitedFiscal = "FiscalSetup/{fiscalSetupId}/LimitedFiscal/{limitedFiscalId}";
}
}