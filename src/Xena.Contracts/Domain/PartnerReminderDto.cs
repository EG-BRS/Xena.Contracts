namespace Xena.Contracts.Domain
{
    public class PartnerReminderDto : IHasIdDto
    {
        public long? Id { get; set; }
        public int InvoiceNumber { get; set; }
        public long? EconomicTransactionId { get; set; }
        public string PartnerName { get; set; }
        public decimal Amount { get; set; }
        public long PartnerId { get; set; }
        public int DaysLate { get; set; }
        public string LastReminderDate { get; set; }
        public string NextReminderStep { get; set; }
        public decimal RemainingAmount { get; set; }
        public long? LastDocumentId { get; set; }
        public string InvoiceEmail { get; set; }
        public int? OrderNumber { get; set; }
        public long? OrderId { get; set; }
        public AddressDto OrderAddress { get; set; }
        public AddressDto OrderDeliveryAddress { get; set; }
        public long? JournalId { get; set; }
        public long? NextReminderStepId { get; set; }
        public int FiscalDateDays { get; set; }
    }
}