namespace Xena.Contracts.Search
{
    public class NorweiganCompanyIndex
    {
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string OrgNumber { get; set; }
        public string Id { get { return OrgNumber; } }
    }
}