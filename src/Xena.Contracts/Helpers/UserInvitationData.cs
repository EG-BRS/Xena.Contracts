namespace Xena.Contracts.Helpers
{
    public class UserInvitationData : BasePaymentRequiredData
    {
        public string Email { get; set; }
        public string[] Roles { get; set; }
        public long? PartnerId { get; set; }
        public long? UserId { get; set; }
    }

    public class ApiCreationData : BasePaymentRequiredData
    {
        public string ApiName { get; set; }
        public long? PartnerId { get; set; }
        public bool GenerateApiKey { get; set; }
    }

    public class RoleChangingData : BasePaymentRequiredData
    {
        public string[] Roles { get; set; }
        public long MembershipId { get; set; }
    }

    public class AppManagementData : BasePaymentRequiredData
    {
        public long[] NewAppIds { get; set; }
        public long MembershipId { get; set; }
    }

    public class BasePaymentRequiredData
    {
        public string CurrencyAbbreviation { get; set; }
        public decimal AmountDue { get; set; }
    } 
}

