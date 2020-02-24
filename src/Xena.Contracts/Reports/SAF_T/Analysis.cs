using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Analysis
    {

        /// <remarks/>
        public string AnalysisType { get; set; }

        /// <remarks/>
        public string AnalysisID { get; set; }
    }
}