using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class TransactionLine
    {
        /// <remarks/>
        public string RecordID { get; set; }

        /// <remarks/>
        public string AccountID { get; set; }

        /// <remarks/>
        [XmlElement("Analysis")]
        public AuditFileGeneralLedgerEntriesJournalTransactionLineAnalysis[] Analysis { get; set; }

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
        public AuditFileGeneralLedgerEntriesJournalTransactionLineCreditAmount CreditAmount { get; set; }

        /// <remarks/>
        public AuditFileGeneralLedgerEntriesJournalTransactionLineDebitAmount DebitAmount { get; set; }

        /// <remarks/>
        public string CrossReference { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool CrossReferenceSpecified { get; set; }

        /// <remarks/>
        public AuditFileGeneralLedgerEntriesJournalTransactionLineTaxInformation TaxInformation { get; set; }

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