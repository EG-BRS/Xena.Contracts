using System;


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
        { get; set; }
        public string RegistrationDateDaysFriendly
        { get; set; }

        public int FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityReserved { get; set; }
        public decimal QuantityTotal { get; set; }
        public decimal RunningTotal { get; set; }

        public decimal? QuantityDebit { get; set; }
        public decimal? QuantityCredit { get; set; }
        public decimal? QuantityReservedDebit { get; set; }
        public decimal? QuantityReservedCredit { get; set; }
        public long PhysicalTransactionId { get; set; }
        public int VoucherNumber { get; set; }

        public long? WarehouseId { get; set; }
        public string WarehouseDescription { get; set; }
        public string LocationAbbreviation { get; set; }
    }
}