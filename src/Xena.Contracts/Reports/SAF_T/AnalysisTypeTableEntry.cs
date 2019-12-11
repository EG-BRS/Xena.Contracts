using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class AnalysisTypeTableEntry
    {
        /// <remarks/>
        public string AnalysisType { get; set; }

        /// <remarks/>
        public string AnalysisTypeDescription { get; set; }

        /// <remarks/>
        public string AnalysisID { get; set; }

        /// <remarks/>
        public string AnalysisIDDescription { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime StartDate { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool StartDateSpecified { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime EndDate { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool EndDateSpecified { get; set; }

        /// <remarks/>
        public string Status { get; set; }

        /// <remarks/>
        public Analysis Analysis { get; set; }
    }
}