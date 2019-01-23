using System.ComponentModel;
using Xena.Common.ExtensionMethods;
using Xena.Common.ExtensionMethods;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Reports.FiscalBalance
{
    public class CaseWarePartnerPostDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public int FiscalDateDays { get; set; }
        private string _fiscalDate = null;
        [ReadOnly(true)]
        public string FiscalDate
        {
            get { return _fiscalDate ?? FiscalDateDays.ToDate().ToString("ddMMyy"); }
            set { _fiscalDate = value; }
        }
        public int VoucherNumber { get; set; }
        public int PartnerAccountNumber { get; set; }
        public string PostType { get; set; }
        public string PartnerName { get; set; }
        public string PartnerAttention { get; set; }
        public string PartnerStreet { get; set; }
        public string PartnerPlaceName { get; set; }
        public string PartnerZip { get; set; }
        public string PartnerCity { get; set; }
        private string _description = null;
        [ReadOnly(true)]
        public string Description
        {
            get { return _description ?? $"{PostType.GetLocalizedConstant()} {VoucherNumber}"; }
            set { _description = value; }
        }
        public decimal CurrencyAmount { get; set; }
        public decimal Amount { get; set; }
        private decimal? _exchangeRate = null;
        [ReadOnly(true)]
        public decimal ExchangeRate
        {
            get { return _exchangeRate ?? (Amount == decimal.Zero ? 1.0m : CurrencyAmount / Amount * 100m); }
            set { _exchangeRate = value; }
        }
        public decimal VatEstTotal { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public long? SettlementId { get; set; }
        public int DueDateDays { get; set; }
        private string _dueDateDaysString = null;
        [ReadOnly(true)]
        public string DueDateDaysString
        {
            get { return _dueDateDaysString ?? DueDateDays.ToDate().ToString("ddMMyy"); }
            set { _dueDateDaysString = value; }
        }
        public long? DepartmentId { get; set; }
        public string DepartmentDescription { get; set; }
        public long? BearerId { get; set; }
        public string BearerDescription { get; set; }
        public long? PurposeId { get; set; }
        public string PurposeDescription { get; set; }
        public string ArchiveAccount { get; set; }
    }
}