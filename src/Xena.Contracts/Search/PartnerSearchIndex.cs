using System.Collections.Generic;

namespace Xena.Contracts.Search
{
    public class PartnerSearchIndex
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }
        public string Attention { get; set; }
        public string URL { get; set; }
        public string GLNNumber { get; set; }
        public string OrgNumber { get; set; }
        public long FiscalSetupId { get; set; }
        public IList<string> Tags { get; set; }
        public IList<string> TelephoneNumberNames { get; set; }
        public IList<string> TelephoneNumbers { get; set; }
        public IList<string> TelephoneNumbersStripped { get; set; }
        public IList<string> Emails { get; set; }
        public IList<string> EmailNames { get; set; }
        public IList<object> MetaData { get; set; }
    }
}