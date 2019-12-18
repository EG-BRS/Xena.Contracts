using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Line
    {
        /// <remarks/>
        public string RecordID { get; set; }

        /// <remarks/>
        public string AccountID { get; set; }

        /// <remarks/>
        [XmlElement("Analysis")]
        public Analysis[] Analysis { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime ValueDate { get; set; }

        /// <remarks/>
        public string SourceDocumentID { get; set; }

        /// <remarks/>
        public string SupplierID { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool SupplierIDSpecified { get; set; }

        /// <remarks/>
        public string Description { get; set; }

        /// <remarks/>
        public CreditAmount CreditAmount { get; set; }

        /// <remarks/>
        public DebitAmount DebitAmount { get; set; }

        /// <remarks/>
        public string CrossReference { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool CrossReferenceSpecified { get; set; }

        /// <remarks/>
        public TaxInformation TaxInformation { get; set; }

        /// <remarks/>
        public string ReferenceNumber { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ReferenceNumberSpecified { get; set; }

        /// <remarks/>
        public string CID { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool CIDSpecified { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime DueDate { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool DueDateSpecified { get; set; }

        /// <remarks/>
        public DateTime SystemEntryTime { get; set; }

        /// <remarks/>
        public string OwnerID { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool OwnerIDSpecified { get; set; }
    }
}