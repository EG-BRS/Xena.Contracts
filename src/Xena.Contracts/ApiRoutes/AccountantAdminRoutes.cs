namespace Xena.Contracts.ApiRoutes
{
    public class AccountantAdminRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/AccountantAdmin"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/AccountantAdmin";

        /// <summary>"Client"</summary>
        public const string GetClientList = "Client";

        /// <summary>"Accountant"</summary>
        public const string GetAccountantList = "Accountant";

        /// <summary>"Client/{clientId}/Accountant"</summary>
        public const string GetAccountantByClientList = "Client/{clientId}/Accountant";

        /// <summary>"Accountant/{accountantId}/Client"</summary>
        public const string GetClientByAccountantList = "Accountant/{accountantId}/Client";

        /// <summary>"Client/{clientId}/Partner"</summary>
        public const string PostPartnerFromClient = "Client/{clientId}/Partner";

        /// <summary>"Client/{clientId}/Accountant/{accountantId}"</summary>
        public const string PostAccountantResource = "Client/{clientId}/Accountant/{accountantId}";

        /// <summary>"Client/{clientId}/Accountant/{accountantId}"</summary>
        public const string DeleteAccountantResource = "Client/{clientId}/Accountant/{accountantId}";

        /// <summary>"Client/{clientId}"</summary>
        public const string DeleteClient = "Client/{id}";

        /// <summary>"AccountantSecurityRoles"</summary>
        public const string GetAccountantSecurityRoleList = "AccountantSecurityRoles";

        /// <summary>"AccountantResourceTempAccess"</summary>
        public const string GetAccountantTempAccess = "AccountantResourceTempAccess";


    }
}