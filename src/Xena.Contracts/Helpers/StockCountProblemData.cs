namespace Xena.Contracts.Helpers
{
    public class StockCountProblemData
    {
        public long Id { get; set; }
        public decimal OriginallyQuantity { get; set; }
        public decimal OriginallyQuantityReserved { get; set; }
        public decimal CurrentQuantity { get; set; }
        public string FriendlyMessage { get; set; }
    }
}