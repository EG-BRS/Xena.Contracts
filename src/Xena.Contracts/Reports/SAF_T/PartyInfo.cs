using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class PartyInfo
    {
        /// <remarks/>
        public PaymentTerms PaymentTerms { get; set; }

        /// <remarks/>
        public string NaceCode { get; set; }

        /// <remarks/>
        public string CurrencyCode { get; set; }

        /// <remarks/>
        public string Type { get; set; }

        /// <remarks/>
        public string Status { get; set; }

        // /// <remarks/>
        // public Analysis Analysis { get; set; }

        /// <remarks/>
        public string Notes { get; set; }
    }
}
