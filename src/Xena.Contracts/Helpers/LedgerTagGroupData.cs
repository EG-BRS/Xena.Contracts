namespace Xena.Contracts.Helpers
{
    public class LedgerTagGroupData
    {
        public long LedgerTagId { get; set; }
        public string LedgerTagDescription { get; set; }
        public int? LedgerTagNumber { get; set; }
        public decimal AmountMonth { get; set; }
        public decimal AmountYearToDate { get; set; }
        public decimal? AmountMonthPrevious { get; set; }
        public decimal? AmountYearToDatePrevious { get; set; }
        public string Group { get; set; }
        public int GroupIndex { get; set; }
    }
    public class PartnerSaldoData
    {
        public long PartnerId { get; set; }
        public int PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public decimal Saldo { get; set; }
    }

    public class StatementData
    {
        public string VatAbbreviation { get; set; }
        public long VatId { get; set; }
        public long LedgertagId { get; set; }
        public string LedgertagDescription { get; set; }
        public string ArticleGroupDescription { get; set; }
        public long ArticleGroupId { get; set; }
        public long PartnerId { get; set; }
        public int PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public decimal StartSaldo { get; set; }
        public decimal EndSaldo { get; set; }
    }
}