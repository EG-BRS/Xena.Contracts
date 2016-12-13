namespace Xena.Contracts.Helpers
{
    public class PartnerManualImportData
    {
        public string OriginalId { get; set; }
        public string ContactNo { get; set; }
        public string EAN { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string VATNo { get; set; }

        public string Name { get; set; }
        public string Street { get; set; }
        public string PlaceName { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} ", ContactNo, Name);
        }
    }
}



 