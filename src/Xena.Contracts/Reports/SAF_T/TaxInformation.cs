using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class TaxInformation
    {

        /// <remarks/>
        public string TaxType { get; set; }

        /// <remarks/>
        public string TaxCode { get; set; }

        /// <remarks/>
        public decimal TaxPercentage { get; set; }

        /// <remarks/>
        public decimal TaxBase { get; set; }

        /// <remarks/>
        public TaxAmount TaxAmount { get; set; }
    }
}