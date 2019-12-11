using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Transaction
    {
        /// <remarks/>
        public string TransactionID { get; set; }

        /// <remarks/>
        public int Period { get; set; }

        /// <remarks/>
        public int PeriodYear { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime TransactionDate { get; set; }

        /// <remarks/>
        public string SourceID { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool SourceIDSpecified { get; set; }

        /// <remarks/>
        public string TransactionType { get; set; }

        /// <remarks/>
        public string Description { get; set; }

        /// <remarks/>
        public string BatchID { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime SystemEntryDate { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime GLPostingDate { get; set; }

        /// <remarks/>
        public string SystemID { get; set; }

        /// <remarks/>
        [XmlElement("Line")]
        public TransactionLine[] Line { get; set; }
    }
}