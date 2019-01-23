using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

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
        private string _partnerTypeTranslated = null;
        [ReadOnly(true)]
        public string PartnerTypeTranslated
        {
            get { return _partnerTypeTranslated ?? PartnerType.GetLocalizedConstant(); }
            set { _partnerTypeTranslated = value; }
        }
        public string PhoneNumber { get; set; }
        public string Note { get; set; }
        private string _uRL;
        [ReadOnly(true)]
        public string URL
        {
            get
            {
                if (string.IsNullOrEmpty(_uRL)) return null;
                return _uRL.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) ? _uRL : $"http://{_uRL}";
            }
            set { _uRL = value; }
        }
        public string GLNNumber { get; set; }
        public string OrgNumber { get; set; }
        public long? SupplierId { get; set; }
        public long? CustomerId { get; set; }
        public long? ResourceId { get; set; }
        public long? DefaultDeliveryAddressId { get; set; }
        private string _shortDescription = null;
        [ReadOnly(true)]
        public string ShortDescription
        {
            get { return _shortDescription ?? (AccountNumber.HasValue ? AccountNumber.ToString() : Address.Name); }
            set { _shortDescription = value; }
        }
        private string _longDescription = null;
        [ReadOnly(true)]
        public string LongDescription
        {
            get { return _longDescription ?? (AccountNumber.HasValue ? $"{AccountNumber} - {Address.Name}" : Address.Name); }
            set { _longDescription = value; }
        }
        public IList<string> Tags { get; set; }
    }
}