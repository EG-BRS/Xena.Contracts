namespace Xena.Contracts.ApiRoutes
{
    public class HomeRoutes
    {
        /// <summary>"Home"</summary>
        public const string Base = "Home";

        /// <summary>"Accountant"</summary>
        public const string GetAccountantList = "Accountant";

        /// <summary>"Provider"</summary>
        public const string GetProviderList = "Provider";

        /// <summary>"Accountant/{accountantId}/ Department"</summary>
        public const string GetAccountantDepartmentList = "Accountant/{accountantId}/Department";
         
        /// <summary>"FiscalSetup"</summary>
        public const string PostFiscalSetup = "FiscalSetup";

        /// <summary>"ResetPassword"</summary>
        public const string PutResetPassword = "ResetPassword";

        /// <summary>"SubscriptionTicket/{id}"</summary>
        public const string DeleteSubscriptionTicket = "SubscriptionTicket/{id}";

        /// <summary>"PartnerInvitation/Accept"</summary>
        public const string PostAcceptPartnerInvitation = "PartnerInvitation/Accept";

        /// <summary>"FiscalSetup/Default"</summary>
        public const string GetFiscalSetupDefault = "FiscalSetup/Default";

        /// <summary>"FiscalSetup"</summary>
        public const string GetFiscalSetup = "FiscalSetup";

        /// <summary>"EpayDataForOnlineUserPayment"</summary>
        public const string PostEpayDataForOnlineUserPayment = "EpayDataForOnlineUserPayment";

    }
}