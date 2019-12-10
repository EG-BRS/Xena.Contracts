using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class TaxRegistration
    {

        /// <remarks/>
        public string TaxRegistrationNumber { get; set; }

        /// <remarks/>
        public string TaxAuthority { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime TaxVerificationDate { get; set; }
    }
}