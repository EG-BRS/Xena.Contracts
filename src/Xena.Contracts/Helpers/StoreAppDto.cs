using System.ComponentModel;
using Xena.Common.ExtensionMethods;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class StoreAppDto : IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        public string Name { get; set; }
        [ReadOnly(true)]
        public string Description { get; set; }
        [ReadOnly(true)]
        public string Details { get; set; }
        [ReadOnly(true)]
        public string ApplicationVisibility { get; set; }

        [ReadOnly(true)]
        public long CreatorId { get; set; }
        public string CreatorName { get; set; }
        [ReadOnly(true)]
        public int NoOfUsers { get; set; }
        //Hvor mange resourcer har installeret den
        [ReadOnly(true)]
        public string ExternalUri { get; set; }
        [ReadOnly(true)]
        public long? IconId { get; set; }
        [ReadOnly(true)]
        public string Category { get; set; }
        [ReadOnly(true)]
        public string TermsMarkdown { get; set; }
        public string Culture { get; set; }
        [ReadOnly(true)]
        public bool IsCountrySpecific { get; set; }
        public string CountryName { get; set; }
        //Fiscal
        public decimal PricePerFiscal { get; set; }
        public decimal PricePerFiscalVatAmount { get; set; }
        public decimal RemainderOfMonthFiscal { get; set; }
        public decimal RemainderOfMonthFiscalVatAmount { get; set; }
        public decimal DiscountFiscal { get; set; }
        public decimal DiscountFiscalVatAmount { get; set; }
        public int? DiscountFiscalEndDays { get; set; }
        private string _discountFiscalEndDaysFriendly = null;
        [ReadOnly(true)]
        public string DiscountFiscalEndDaysFriendly
        {
            get { return _discountFiscalEndDaysFriendly ?? DiscountFiscalEndDays.FriendlyString(); }
            set { _discountFiscalEndDaysFriendly = value; }
        }

        //User
        public decimal PricePerUser { get; set; }
        public decimal PricePerUserVatAmount { get; set; }
        public decimal RemainderOfMonthUser { get; set; }
        public decimal RemainderOfMonthUserVatAmount { get; set; }
        public decimal DiscountUser { get; set; }
        public decimal DiscountUserVatAmount { get; set; }
        public int? DiscountUserEndDays { get; set; }
        private string _discountUserEndDaysFriendly = null;

        [ReadOnly(true)]
        public string DiscountUserEndDaysFriendly
        {
            get { return _discountUserEndDaysFriendly ?? DiscountUserEndDays.FriendlyString(); }
            set { _discountUserEndDaysFriendly = value; }
        }

        public string CurrencyAbbreviation { get; set; }
        [ReadOnly(true)]
        public long? UserArticleId { get; set; }
        [ReadOnly(true)]
        public long? FiscalArticleId { get; set; }
        [ReadOnly(true)]
        public bool IsBundle { get; set; }
        private string _applicationVisibilityTranslated = null;
        [ReadOnly(true)]
        public string ApplicationVisibilityTranslated
        {
            get
            {
                return _applicationVisibilityTranslated ?? (string.IsNullOrEmpty(ApplicationVisibility)
                           ? string.Empty
                           : ApplicationVisibility.GetLocalizedConstant());
            }
            set { _applicationVisibilityTranslated = value; }
        }
        private string _categoryTranslated = null;
        [ReadOnly(true)]
        public string CategoryTranslated
        {
            get
            {
                return _categoryTranslated ??
                       (string.IsNullOrEmpty(Category) ? string.Empty : Category.GetLocalizedConstant());
            }
            set { _categoryTranslated = value; }
        }
        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get { return _cultureDisplayName ?? Culture.GetLocalizedCultureName(); }
            set { _cultureDisplayName = value; }
        }
        private string _countryDisplayName = null;
        [ReadOnly(true)]
        public string CountryDisplayName
        {
            get { return _countryDisplayName ?? CountryName.GetLocalizedCountryName(); }
            set { _countryDisplayName = value; }
        }
    }
}