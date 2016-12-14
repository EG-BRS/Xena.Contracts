using System;
using Xena.Contracts.ExtensionMethods;


namespace Xena.Contracts.Domain
{
    public class FiscalSetupDto : IEntityDto
    {
        private string _fiscalSetupType;

        public string FiscalSetupType
        {
            get { return _fiscalSetupType??FiscalSetupTypes.Free; }
            set { _fiscalSetupType = value; }
        }

        public string Color { get; set; }
        public string OrgNumber { get; set; }
        public AddressDto Address { get; set; }
        public bool HasArchive { get; set; }
        public long? LogoId { get; set; }
        public long? AccountantId { get; set; }
        public string AccountantName { get; set; }
        public long? DefaultSalesVatId { get; set; }
        public long? DefaultPurchasingVatId { get; set; }
        public long? DefaultEUVatGoodsId { get; set; }
        public long? DefaultEUVatServicesId { get; set; }
        public string DefaultSalesVatAbbreviation { get; set; }
        public string DefaultPurchasingVatAbbreviation { get; set; }
        public string DefaultEUVatGoodsAbbreviation { get; set; }
        public string DefaultEUVatServicesAbbreviation { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public string AppointmentSetupColour { get; set; }
        public long? XenaSubscriptionId { get; set; }
        public bool? IsXenaSubscriptionActive { get; set; }
        public long? DibsMerchantId { get; set; }
        public long? PaymentLedgerTagId { get; set; }
        public string PaymentLedgerTagDescription { get; set; }
        public int? PaymentLedgerTagNumber { get; set; }
        public bool IsMD5KeyEntered { get; set; }

        public string Culture { get; set; }
        public string DepartmentDescription { get; set; }
        public string CustomerAccount { get; set; }
        public string SystemEquityAccount { get; set; }
        public string SupplierAccount { get; set; }
        public string LightHighlightColour { get; set; }
        public string DarkHighlightColour { get; set; }
        public string DarkHighlightTextColour { get; set; }
        public string InvertedTextColour { get; set; }
        public long? Id { get; set; }
        public int Version { get; set; }
        public bool IsDeactivated { get; set; }
        public bool RegisteredForVat { get; set; }
        public Guid? SproomKey { get; set; }

        public string RecipientAddressType { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public long? AccountantDepartmentId { get; set; }
        public long? LedgerId { get; set; }
        public string LedgerDescription { get; set; }
        public string AccountantDepartmentDescription { get; set; }

        public bool UsesSproom { get; set; }
        public string CurrencyDescription { get; set; }
        public string CultureDisplayName { get; set; }
        public bool IsAccountant { get; set; }
        public bool IsFacade { get; set; }
        public bool HasExpiringFiscalPeriod { get; set; }
    }
}