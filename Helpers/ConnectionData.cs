namespace Xena.Contracts.Helpers
{
    public class ConnectionData
    {
        public bool HasFiscalAsPartner { get; set; }
        public bool PartnerAllowsOnlinePayment { get; set; }
        public long? PartnerId { get; set; }
        public string FiscalSetupName { get; set; }
    }
}