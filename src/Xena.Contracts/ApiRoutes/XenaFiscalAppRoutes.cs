namespace Xena.Contracts.ApiRoutes
{
    public class XenaFiscalAppRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/XenaFiscalApp"</summary>
        public const string Base = "Fiscal/{fiscalId}/XenaFiscalApp";

        /// <summary>"Installed"</summary>
        public const string GetInstalled = "Installed";

        /// <summary>"Installed/{id}"</summary>
        public const string GetByAppId = "Installed/{appId}";

        /// <summary>"{appId}/Unsubscribe"</summary>
        public const string Unsubscribe = "{appId}/Unsubscribe";

        /// <summary>"InstalledFiscalApps"</summary>
        public const string GetInstalledFiscalApps = "InstalledFiscalApps";


    }
}