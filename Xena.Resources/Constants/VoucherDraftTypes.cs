namespace Xena.Resources.Constants
{
    public static class VoucherDraftTypes
    {
        public static string[] All => new[] {Finance, CreditorIncomingInvoice, PartnerPayment};
        public const string Finance = "VoucherDraftType_Finance"; 
        public const string CreditorIncomingInvoice = "VoucherDraftType_CreditorIncomingInvoice"; 
        public const string PartnerPayment = "VoucherDraftType_PartnerPayment"; 
    }
}