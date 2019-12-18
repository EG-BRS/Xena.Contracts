using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Address
    {
        /// <remarks/>
        public string StreetName { get; set; }

        /// <remarks/>
        public string Number { get; set; }

        /// <remarks/>
        public string AdditionalAddressDetail { get; set; }

        /// <remarks/>
        public string City { get; set; }

        /// <remarks/>
        public string PostalCode { get; set; }

        /// <remarks/>
        public string Region { get; set; }

        /// <remarks/>
        public string Country { get; set; }

        /// <remarks/>
        public string AddressType { get; set; }
    }
}