using System;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class ArticlePostDto : TransactionalDto
    {
        public long ArticleId { get; set; }
        public long? LocationId { get; set; }
        public long? ArticleVariantId { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public string Description { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long? OrderId { get; set; }
        public int? OrderNumber { get; set; }
        public int RegistrationDateDays
        {
            get { return CreatedAt.DaysSince1970_01_01(); }
        }
        public string RegistrationDateDaysFriendly
        {
            get { return ((int?)RegistrationDateDays).FriendlyString(); }
        }

        public int FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.FriendlyString(); }
        }
        public decimal Quantity { get; set; }
        public decimal QuantityReserved { get; set; }
        public decimal QuantityTotal { get { return Quantity + QuantityReserved; }}
        public decimal RunningTotal { get; set; }

        public decimal? QuantityDebit { get { return Quantity > 0 ? Math.Abs(Quantity) : (decimal?)null; } }
        public decimal? QuantityCredit { get { return Quantity < 0 ? Math.Abs(Quantity) : (decimal?)null; } }
        public decimal? QuantityReservedDebit { get { return QuantityReserved > 0 ? Math.Abs(QuantityReserved) : (decimal?)null; } }
        public decimal? QuantityReservedCredit { get { return QuantityReserved < 0 ? Math.Abs(QuantityReserved) : (decimal?)null; } }
        public long PhysicalTransactionId { get; set; }
        public int VoucherNumber { get; set; }

        public long? WarehouseId { get; set; }
        public string WarehouseDescription { get; set; }
        public string LocationAbbreviation { get; set; }
    }
}