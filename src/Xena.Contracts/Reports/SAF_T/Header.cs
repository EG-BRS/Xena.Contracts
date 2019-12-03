using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Header
    {
        /// <remarks/>
        public decimal AuditFileVersion { get; set; }

        /// <remarks/>
        public string AuditFileCountry { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime AuditFileDateCreated { get; set; }

        /// <remarks/>
        public string SoftwareCompanyName { get; set; }

        /// <remarks/>
        public string SoftwareID { get; set; }

        /// <remarks/>
        public decimal SoftwareVersion { get; set; }

        /// <remarks/>
        public Company Company { get; set; }

        /// <remarks/>
        public string DefaultCurrencyCode { get; set; }

        /// <remarks/>
        public SelectionCriteria SelectionCriteria { get; set; }

        /// <remarks/>
        public string HeaderComment { get; set; }

        /// <remarks/>
        public string TaxAccountingBasis { get; set; }

        /// <remarks/>
        public ushort UserID { get; set; }
    }
}