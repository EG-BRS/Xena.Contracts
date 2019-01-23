using System;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ArticlePostDto : TransactionalDto
    {
        public long? ArticleVariantId { get; set; }
        public decimal RunningTotal { get; set; }
        [ReadOnly(true)]
        public long ArticleId { get; set; }
        [ReadOnly(true)]
        public long? WarehouseId { get; set; }
        [ReadOnly(true)]
        public long? LocationId { get; set; }
        [ReadOnly(true)]
        public long PhysicalTransactionId { get; set; }
        [ReadOnly(true)]
        public decimal Quantity { get; set; }
        [ReadOnly(true)]
        public decimal QuantityReserved { get; set; }
        [ReadOnly(true)]
        public string Description { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string ArticleVariantAbbreviation { get; set; }
        [ReadOnly(true)]
        public string ArticleNumber { get; set; }
        [ReadOnly(true)]
        public string ArticleDescription { get; set; }
        [ReadOnly(true)]
        public long? OrderId { get; set; }
        [ReadOnly(true)]
        public int? OrderNumber { get; set; }
        [ReadOnly(true)]
        public int FiscalDateDays { get; set; }
        [ReadOnly(true)]
        public int VoucherNumber { get; set; }
        [ReadOnly(true)]
        public string WarehouseDescription { get; set; }
        [ReadOnly(true)]
        public string LocationAbbreviation { get; set; }

        private int? _registrationDateDays;
        [ReadOnly(true)]
        public int RegistrationDateDays
        {
            get { return _registrationDateDays ?? CreatedAt.DaysSince1970_01_01(); }
            set { _registrationDateDays = value; }
        }

        private string _registrationDateDaysFriendly;
        [ReadOnly(true)]
        public string RegistrationDateDaysFriendly
        {
            get { return _registrationDateDaysFriendly ?? ((int?)RegistrationDateDays).FriendlyString(); }
            set { _registrationDateDaysFriendly = value; }
        }

        private string _fiscalDateDaysFriendly;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }

        private decimal? _quantityTotal;
        [ReadOnly(true)]
        public decimal QuantityTotal
        {
            get { return _quantityTotal ?? Quantity + QuantityReserved; }
            set { _quantityTotal = value; }
        }

        private decimal? _quantityDebit;
        [ReadOnly(true)]
        public decimal? QuantityDebit
        {
            get
            {
                return _quantityDebit ?? (Quantity > 0 ? Math.Abs(Quantity) : (decimal?)null);
            }
            set { _quantityDebit = value; }
        }

        private decimal? _quantityCredit;
        [ReadOnly(true)]
        public decimal? QuantityCredit
        {
            get { return _quantityCredit ?? (Quantity < 0 ? Math.Abs(Quantity) : (decimal?)null); }
            set { _quantityCredit = value; }
        }

        private decimal? _quantityReservedDebit;
        [ReadOnly(true)]
        public decimal? QuantityReservedDebit
        {
            get { return _quantityReservedDebit ?? (QuantityReserved > 0 ? Math.Abs(QuantityReserved) : (decimal?)null); }
            set { _quantityReservedDebit = value; }
        }

        private decimal? _quantityReservedCredit;
        [ReadOnly(true)]
        public decimal? QuantityReservedCredit
        {
            get
            {
                return _quantityReservedCredit ?? (QuantityReserved < 0 ? Math.Abs(QuantityReserved) : (decimal?)null);
            }
            set { _quantityReservedCredit = value; }
        }

        public long? PrimoArticlePostId { get; set; }
    }
}