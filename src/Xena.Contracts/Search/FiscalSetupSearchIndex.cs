using System.Collections.Generic;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Search
{
    public class FiscalSetupSearchIndex
    {
        public long Id { get; set; }
        public bool IsDeactivated { get; set; }
        public long? ProviderId { get; set; }
        public long? XenaSubscriptionId { get; set; }
        public string Name { get; set; }
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }
        public string OrgNumber { get; set; }
        public int CreatedDate { get; set; }
        private string _createdDateFriendly = null;
        [ReadOnly(true)]
        public string CreatedDateFriendly
        {
            get { return _createdDateFriendly ?? CreatedDate.FriendlyString(); }
            set { _createdDateFriendly = value; }
        }
        //PartnerRelated
        public long? PartnerId { get; set; }
        public int? AccountNumber { get; set; }
        public IList<string> Tags { get; set; }
        public IList<object> MetaData { get; set; }
    }
}