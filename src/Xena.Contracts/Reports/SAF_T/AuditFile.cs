using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    [XmlRoot(Namespace = "urn:StandardAuditFile-Taxation-Financial:NO", IsNullable = false)]
    public class AuditFile
    {
//        /// <remarks/>
//        public Header Header { get; set; }

        /// <remarks/>
        public MasterFiles MasterFiles { get; set; }

//        /// <remarks/>
//        public AuditFileGeneralLedgerEntries GeneralLedgerEntries { get; set; }
    }


    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class AuditFileGeneralLedgerEntriesJournalTransactionLineAnalysis
    {

        /// <remarks/>
        public string AnalysisType { get; set; }

        /// <remarks/>
        public string AnalysisID { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class AuditFileGeneralLedgerEntriesJournalTransactionLineCreditAmount
    {
        /// <remarks/>
        public decimal Amount { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class AuditFileGeneralLedgerEntriesJournalTransactionLineDebitAmount
    {
        /// <remarks/>
        public decimal Amount { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class AuditFileGeneralLedgerEntriesJournalTransactionLineTaxInformation
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
        public AuditFileGeneralLedgerEntriesJournalTransactionLineTaxInformationTaxAmount TaxAmount { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class AuditFileGeneralLedgerEntriesJournalTransactionLineTaxInformationTaxAmount
    {
        /// <remarks/>
        public decimal Amount { get; set; }
    }
}