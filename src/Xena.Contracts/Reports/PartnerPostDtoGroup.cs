using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Reports
{
    public class PartnerPostDtoGroup
    {
        private decimal? _endRemainingTotal = null;
        private decimal? _amountDue = null;
        private decimal? _endAmountTotal = null;

        public string PartnerName { get; set; }
        public int PartnerAccountNumber { get; set; }
        public List<PartnerPostDto> PartnerPosts { get; set; }
        public decimal StartingTotal { get; set; }
        public decimal StartingAmountDue { get; set; }
        public int ReportDateFrom { get; set; }
        public int ReportDateTo { get; set; }

        [ReadOnly(true)]
        public decimal EndRemainingAmountTotal
        {
            get { return _endRemainingTotal ?? (StartingTotal + PartnerPosts.Sum(pp => pp.RemainingAmount)); }
            set => _endRemainingTotal = value;
        }

        [ReadOnly(true)]
        public decimal EndAmountTotal
        {
            get { return _endAmountTotal ?? (StartingTotal + PartnerPosts.Sum(pp => pp.Amount)); }
            set => _endAmountTotal = value;
        }

        [ReadOnly(true)]
        public decimal AmountDue
        {
            get { return _amountDue ?? (StartingAmountDue + PartnerPosts.Where(pp => pp.DueDateDays <= ReportDateTo && pp.FiscalDateDays >= ReportDateFrom).Sum(pp => pp.RemainingAmount)); }
            set => _amountDue = value;
        }
    }
}