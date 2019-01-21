namespace Xena.Contracts.Helpers
{
    public class OngoingOrderTaskHistoricData
    {
        public long OrderTaskId { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public decimal CostTotal { get; set; }
        public decimal EstInvoiceTotal { get; set; }
        public override string ToString()
        {
            return Abbreviation;
        }
    }
}