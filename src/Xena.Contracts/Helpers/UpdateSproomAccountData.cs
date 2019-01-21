namespace Xena.Contracts.Helpers
{
    public class UpdateSproomAccountData
    {
        public long FiscalSetupId { get; set; }
        public string RecipientAddressType { get; set; }
        public string RecipientAddress { get; set; }
        public string SproomKey { get; set; }
    }
}