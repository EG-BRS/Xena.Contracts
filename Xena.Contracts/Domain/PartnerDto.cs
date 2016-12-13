using System.Collections.Generic;
using System.Threading;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class PartnerDto : EntityDto
    {
        public PartnerDto()
        {
            Tags = new List<string>();
        }
        public int? AccountNumber { get; set; }
        public AddressDto Address { get; set; }
        public long? ReferenceFiscalSetupId { get; set; }
        public long? ReferenceUserId { get; set; }
        public string Attention { get; set; }
        public string PartnerType { get; set; }
        public string PartnerTypeTranslated
        {
            get { return PartnerType.GetLocalizedConstant(); }
        }
        public string PhoneNumber { get; set; }
        public string Note { get; set; }
        private string _uRL;
        public string URL
        {
            get
            {
                if (string.IsNullOrEmpty(_uRL)) return null;
                return _uRL.StartsWith("http", true, Thread.CurrentThread.CurrentCulture) ? _uRL : string.Format("http://{0}", _uRL);
            }
            set { _uRL = value; }
        }
        public string GLNNumber { get; set; }
        public string OrgNumber { get; set; }
        public long? SupplierId { get; set; }
        public long? CustomerId { get; set; }
        public long? ResourceId { get; set; }
        public long? DefaultDeliveryAddressId { get; set; }

        public string ShortDescription
        {
            get { return AccountNumber.HasValue ? AccountNumber.ToString() : Address.Name; }
        }

        public string LongDescription
        {
            get { return AccountNumber.HasValue ? string.Format("{0} - {1}", AccountNumber, Address.Name) : Address.Name; }
        }
        public IList<string> Tags { get; set; }
    }
}