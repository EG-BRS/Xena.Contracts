using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class TaxCodeDetails
    {

        /// <remarks/>
        public string TaxCode { get; set; }

        /// <remarks/>
        public string Description { get; set; }

        /// <remarks/>
        public decimal TaxPercentage { get; set; }

        /// <remarks/>
        public string Country { get; set; }

        /// <remarks/>
        public string StandardTaxCode { get; set; }

        /// <remarks/>
        [XmlElement("BaseRate")]
        public decimal[] BaseRate { get; set; }
    }
}