using System.ComponentModel;
using Xena.Common.ExtensionMethods;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class OrderInvoiceAggregateDto : IHasIdDto
    {
        public long? Id { get; set; }
        public string ContextType { get; set; }
        public string PartnerPostType { get; set; }
        public TotalsDto Totals { get; set; }
        public int VoucherNumber { get; set; }
        public int FiscalDateDays { get; set; }
        private string _fiscalDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }
        public long? ResourceId { get; set; }

        public long? OrderId { get; set; }
        public int OrderNumber { get; set; }
        public AddressDto OrderAddress { get; set; }
        public AddressDto OrderDeliveryAddress { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int PartnerAccountNumber { get; set; }
        public OrderJournalEntryDto Journal { get; set; }
        public string SupplierInvoiceNumber { get; set; }

        public long? SettlementId { get; set; }
        public bool IsFullyDelivered { get; set; }
        public long FiscalSetupId { get; set; }
        private string _contextTypeTranslated = null;
        [ReadOnly(true)]
        public string ContextTypeTranslated
        {
            get { return _contextTypeTranslated ?? ContextType.GetLocalizedConstant(); }
            set { _contextTypeTranslated = value; }
        }

        private bool? _isSettled = null;
        [ReadOnly(true)]
        public bool IsSettled
        {
            get { return _isSettled ?? SettlementId.HasValue; }
            set { _isSettled = value; }
        }
        private string _userName = null;
        [ReadOnly(true)]
        public string UserName
        {
            get { return _userName ?? (Journal == null ? string.Empty : Journal.ResponsibleName); }
            set { _userName = value; }
        }
        private long? _documentId = null;
        [ReadOnly(true)]
        public long? DocumentId
        {
            get { return _documentId ?? Journal?.DocumentId; }
            set { _documentId = value; }
        }
        private string _partnerPostTypeTranslated = null;
        [ReadOnly(true)]
        public string PartnerPostTypeTranslated
        {
            get
            {
                return _partnerPostTypeTranslated ?? (string.IsNullOrEmpty(PartnerPostType)
                           ? string.Empty
                           : PartnerPostType.GetLocalizedConstant());
            }
            set { _partnerPostTypeTranslated = value; }
        }
    }
}