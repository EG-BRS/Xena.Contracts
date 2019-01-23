using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;
using Xena.Contracts.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class FiscalSetupDto : IEntityDto
    {
        private string _fiscalSetupType;
        public FiscalSetupDto()
        {
        }
        public FiscalSetupDto(string accountantName)
        {
            AccountantName = accountantName;
        }
        public long? Id { get;  set; }
        public int Version { get; set; }
        public bool IsDeactivated { get; set; }
        [Required]
        [ReadOnly(true)]
        public string FiscalSetupType
        {
            get { return _fiscalSetupType ?? FiscalSetupTypes.Free; }
            set { _fiscalSetupType = value; }
        }

        public string Color { get; set; }
        public string OrgNumber { get; set; }
        public AddressDto Address { get; set; }
        public long? LogoId { get; set; }
        public long? WorkScheduleId { get; set; }
        public long? AccountantId { get; set; }
        public long? DefaultSalesVatId { get; set; }
        public long? DefaultPurchasingVatId { get; set; }
        public long? DefaultEUVatGoodsId { get; set; }
        public long? DefaultEUVatServicesId { get; set; }
        [Required]
        public string CurrencyAbbreviation { get; set; }
        public string AppointmentSetupColour { get; set; }
        public long? PaymentLedgerTagId { get; set; }
        public int? PaymentLedgerTagNumber { get; set; }
        [Required]
        public string Culture { get; set; }
        public string LightHighlightColour { get; set; }
        public string DarkHighlightColour { get; set; }
        public string DarkHighlightTextColour { get; set; }
        public string InvertedTextColour { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public long? AccountantDepartmentId { get; set; }
        public long? LedgerId { get; set; }
        public bool RegisteredForVat { get; set; }
        public long? DibsMerchantId { set; get; }
        public long? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderCssClass { get; set; }
        public bool HasArchive { get; set; }
        public long? XenaSubscriptionId { get; set; }
        public bool IsMD5KeyEntered { get; set; }
        [ReadOnly(true)]
        public bool HasExpiringFiscalPeriod { get;  set; }
        [ReadOnly(true)]
        public bool HasExpiringDiscountCodes { get;  set; }

        //Convinience properties
        [ReadOnly(true)]
        public bool IsProvider { get; set; }
        [ReadOnly(true)]
        public Guid? SproomKey { get; set; }
        [ReadOnly(true)]
        public long? ResourceId { get; set; }
        [ReadOnly(true)]
        public string RecipientAddressType { get; set; }
        [ReadOnly(true)]
        public bool? IsXenaSubscriptionActive { get; set; }
        [ReadOnly(true)]
        public string AccountantName { get; set; }
        [ReadOnly(true)]
        public string DefaultSalesVatAbbreviation { get; set; }
        [ReadOnly(true)]
        public string DefaultPurchasingVatAbbreviation { get; set; }
        [ReadOnly(true)]
        public string DefaultEUVatGoodsAbbreviation { get; set; }
        [ReadOnly(true)]
        public string DefaultEUVatServicesAbbreviation { get; set; }
        [ReadOnly(true)]
        public string PaymentLedgerTagDescription { get; set; }
        [ReadOnly(true)]
        public string DepartmentDescription { get; set; }
        [ReadOnly(true)]
        public string LedgerDescription { get; set; }
        [ReadOnly(true)]
        public string AccountantDepartmentDescription { get; set; }

        private bool? _usesSproom;
        [ReadOnly(true)]
        public bool UsesSproom
        {
            get { return _usesSproom ?? SproomKey != null; }
            set { _usesSproom = value; }
        }

        private string _currencyDescription = null;
        [ReadOnly(true)]
        public string CurrencyDescription
        {
            get { return _currencyDescription ?? CurrencyAbbreviation.GetLocalizedCurrencyName(); }
            set { _currencyDescription = value; }
        }

        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get { return _cultureDisplayName ?? Culture.GetLocalizedCultureName(); }
            set { _cultureDisplayName = value; }
        }

        private bool? _isAccountant;
        [ReadOnly(true)]
        public bool IsAccountant
        {
            get { return _isAccountant ?? this.IsAccountant(); }
            set { _isAccountant = value; }
        }

        private bool? _isFacade;
        [ReadOnly(true)]
        public bool IsFacade
        {
            get { return _isFacade ?? this.IsFacade(); }
            set { _isFacade = value; }
        }

        [ReadOnly(true)]
        public string AgreementNumber { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}