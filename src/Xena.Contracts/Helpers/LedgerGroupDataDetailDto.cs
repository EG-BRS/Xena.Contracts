﻿using System;
using System.ComponentModel;

namespace Xena.Contracts.Helpers
{
    public class LedgerGroupDataDetailDto
    {
        public string Controller { get; set; }
        public string ControllerAction { get; set; }
        public string Id { get; set; }
        public int? AccountNumber { get; set; }
        public string AccountDescription { get; set; }
        public string LedgerAccount { get; set; }
        public string Group { get; set; }
        public int GroupIndex { get; set; }

        private string _description;

        [ReadOnly(true)]
        public string Description
        {
            get => _description ?? (AccountNumber.HasValue ? $"{AccountNumber} {AccountDescription}" : AccountDescription);
            set => _description = value;
        }

        private decimal? _differencePeriod;

        [ReadOnly(true)]
        public decimal? DifferencePeriod
        {
            get => _differencePeriod ?? AmountMonth - AmountMonthPrevious;
            set => _differencePeriod = value;
        }

        private decimal? _differenceYearToDate;

        [ReadOnly(true)]
        public decimal? DifferenceYearToDate
        {
            get => _differenceYearToDate ?? AmountYearToDate - AmountYearToDatePrevious;
            set => _differenceYearToDate = value;
        }

        private decimal? _differencePeriodPercentage;

        [ReadOnly(true)]
        public decimal? DifferencePeriodPercentage
        {
            get =>
                _differencePeriodPercentage ?? (DifferencePeriod.HasValue && AmountMonthPrevious.HasValue &&
                                                AmountMonthPrevious.Value != decimal.Zero
                    ? DifferencePeriod / AmountMonthPrevious.Value * 100M
                    : null);
            set => _differencePeriodPercentage = value;
        }

        private decimal? _differenceYearToDatePercentage;

        [ReadOnly(true)]
        public decimal? DifferenceYearToDatePercentage
        {
            get =>
                _differenceYearToDatePercentage ?? (DifferenceYearToDate.HasValue && AmountYearToDatePrevious.HasValue &&
                                                    AmountYearToDatePrevious.Value != decimal.Zero
                    ? DifferenceYearToDate / AmountYearToDatePrevious.Value * 100M
                    : null);
            set => _differenceYearToDatePercentage = value;
        }

        public decimal AmountMonth { get; set; }

        private decimal? _amountMonthDebit;

        [ReadOnly(true)]
        public decimal? AmountMonthDebit
        {
            get => _amountMonthDebit ?? (AmountMonth > 0 ? Math.Abs(AmountMonth) : (decimal?)null);
            set => _amountMonthDebit = value;
        }

        private decimal? _amountMonthCredit;

        [ReadOnly(true)]
        public decimal? AmountMonthCredit
        {
            get => _amountMonthCredit ?? (AmountMonth < 0 ? Math.Abs(AmountMonth) : (decimal?)null);
            set => _amountMonthCredit = value;
        }

        public decimal AmountYearToDate { get; set; }

        private decimal? _amountYearToDateDebit;

        [ReadOnly(true)]
        public decimal? AmountYearToDateDebit
        {
            get => _amountYearToDateDebit ?? (AmountYearToDate > 0 ? Math.Abs(AmountYearToDate) : (decimal?)null);
            set => _amountYearToDateDebit = value;
        }

        private decimal? _amountYearToDateCredit;

        [ReadOnly(true)]
        public decimal? AmountYearToDateCredit
        {
            get => _amountYearToDateCredit ?? (AmountYearToDate < 0 ? Math.Abs(AmountYearToDate) : (decimal?)null);
            set => _amountYearToDateCredit = value;
        }

        public decimal? AmountMonthPrevious { get; set; }

        private decimal? _amountMonthDebitPrevious;

        [ReadOnly(true)]
        public decimal? AmountMonthDebitPrevious
        {
            get =>
                _amountMonthDebitPrevious ?? (AmountMonthPrevious.HasValue && AmountMonthPrevious.Value > 0
                    ? Math.Abs(AmountMonthPrevious.Value)
                    : (decimal?)null);
            set => _amountMonthDebitPrevious = value;
        }

        private decimal? _amountMonthCreditPrevious;

        [ReadOnly(true)]
        public decimal? AmountMonthCreditPrevious
        {
            get =>
                _amountMonthCreditPrevious ?? (AmountMonthPrevious.HasValue && AmountMonthPrevious.Value < 0
                    ? Math.Abs(AmountMonthPrevious.Value)
                    : (decimal?)null);
            set => _amountMonthCreditPrevious = value;
        }

        public decimal? AmountYearToDatePrevious { get; set; }

        private decimal? _amountYearToDateDebitPrevious;

        [ReadOnly(true)]
        public decimal? AmountYearToDateDebitPrevious
        {
            get =>
                _amountYearToDateDebitPrevious ?? (AmountYearToDatePrevious.HasValue && AmountYearToDatePrevious.Value > 0
                    ? Math.Abs(AmountYearToDatePrevious.Value)
                    : (decimal?)null);
            set => _amountYearToDateDebitPrevious = value;
        }

        private decimal? _amountYearToDateCreditPrevious;

        [ReadOnly(true)]
        public decimal? AmountYearToDateCreditPrevious
        {
            get =>
                _amountYearToDateCreditPrevious ?? (AmountYearToDatePrevious.HasValue && AmountYearToDatePrevious.Value < 0
                    ? Math.Abs(AmountYearToDatePrevious.Value)
                    : (decimal?)null);
            set => _amountYearToDateCreditPrevious = value;
        }
    }
}