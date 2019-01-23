using System;
using System.ComponentModel;

namespace Xena.Contracts.Helpers
{
    public class LedgerGroupDataDto
    {
        public string Group { get; set; }
        public string TranslatedGroup { get; set; }
        public decimal AmountMonth { get; set; }
        public decimal AmountYearToDate { get; set; }
        public decimal? AmountMonthPrevious { get; set; }
        public decimal? AmountYearToDatePrevious { get; set; }

        private decimal? _differencePeriod;
        [ReadOnly(true)]
        public decimal? DifferencePeriod
        {
            get { return _differencePeriod?? (AmountMonthPrevious.HasValue ? AmountMonth - AmountMonthPrevious.Value : (decimal?) null); }
            set { _differencePeriod = value; }
        }

        private decimal? _differenceYearToDate;
        public decimal? DifferenceYearToDate
        {
            get
            {
                return _differenceYearToDate ?? (AmountYearToDatePrevious.HasValue
                    ? AmountYearToDate - AmountYearToDatePrevious.Value
                    : (decimal?) null);
            }
            set { _differenceYearToDate = value; }
        }

        private decimal? _differencePeriodPercentage;
        [ReadOnly(true)]
        public decimal? DifferencePeriodPercentage
        {
            get
            {
                return _differencePeriodPercentage ?? (DifferencePeriod.HasValue && AmountMonthPrevious.HasValue &&
                                                       AmountMonthPrevious.Value != decimal.Zero
                           ? DifferencePeriod / AmountMonthPrevious.Value * 100M
                           : null);
            }
            set { _differencePeriodPercentage = value; }
        }

        private decimal? _differenceYearToDatePercentage;
        [ReadOnly(true)]
        public decimal? DifferenceYearToDatePercentage
        {
            get
            {
                return _differenceYearToDatePercentage ?? (DifferenceYearToDate.HasValue && AmountYearToDatePrevious.HasValue &&
                       AmountYearToDatePrevious.Value != decimal.Zero
                    ? DifferenceYearToDate / AmountYearToDatePrevious.Value * 100M
                    : null);
            }
            set { _differenceYearToDatePercentage = value; }
        }

        private decimal? _amountMonthDebit;
        [ReadOnly(true)]
        public decimal? AmountMonthDebit
        {
            get { return _amountMonthDebit ?? (AmountMonth > 0 ? Math.Abs(AmountMonth) : (decimal?) null); }
            set { _amountMonthDebit = value; }
        }

        private decimal? _amountMonthCredit;
        [ReadOnly(true)]
        public decimal? AmountMonthCredit
        {
            get { return _amountMonthCredit ?? (AmountMonth < 0 ? Math.Abs(AmountMonth) : (decimal?) null); }
            set { _amountMonthCredit = value; }
        }

        private decimal? _amountYearToDateDebit;
        [ReadOnly(true)]
        public decimal? AmountYearToDateDebit
        {
            get
            {
                return _amountYearToDateDebit ?? (AmountYearToDate > 0 ? Math.Abs(AmountYearToDate) : (decimal?) null);
            }
            set { _amountYearToDateDebit = value; }
        }

        private decimal? _amountYearToDateCredit;
        [ReadOnly(true)]
        public decimal? AmountYearToDateCredit
        {
            get { return _amountYearToDateCredit ?? (AmountYearToDate < 0 ? Math.Abs(AmountYearToDate) : (decimal?) null); }
            set { _amountYearToDateCredit = value; }
        }

        private decimal? _amountMonthPreviousDebit;
        [ReadOnly(true)]
        public decimal? AmountMonthPreviousDebit
        {
            get
            {
                return _amountMonthPreviousDebit?? (AmountMonthPrevious.HasValue && AmountMonthPrevious > 0
                    ? Math.Abs(AmountMonthPrevious.Value)
                    : (decimal?) null);
            }
            set { _amountMonthPreviousDebit = value; }
        }

        private decimal? _amountMonthPreviousCredit;
        [ReadOnly(true)]
        public decimal? AmountMonthPreviousCredit
        {
            get
            {
                return _amountMonthPreviousCredit ?? (AmountMonthPrevious.HasValue && AmountMonthPrevious < 0
                           ? Math.Abs(AmountMonthPrevious.Value)
                           : (decimal?) null);
            }
            set { _amountMonthPreviousCredit = value; }
        }

        private decimal? _amountYearToDatePreviousDebit;
        [ReadOnly(true)]
        public decimal? AmountYearToDatePreviousDebit
        {
            get
            {
                return _amountYearToDatePreviousDebit ??
                       (AmountYearToDatePrevious.HasValue && AmountYearToDatePrevious > 0
                           ? Math.Abs(AmountYearToDatePrevious.Value)
                           : (decimal?) null);
            }
            set { _amountYearToDatePreviousDebit = value; }
        }

        private decimal? _amountYearToDatePreviousCredit;
        [ReadOnly(true)]
        public decimal? AmountYearToDatePreviousCredit
        {
            get
            {
                return _amountYearToDatePreviousCredit ?? (AmountYearToDatePrevious.HasValue && AmountYearToDatePrevious < 0
                    ? Math.Abs(AmountYearToDatePrevious.Value)
                    : (decimal?) null);
            }
            set { _amountYearToDatePreviousCredit = value; }
        }
    }
}