using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class SelectionCriteria
    {
        /// <remarks/>
        public int PeriodStart { get; set; }

        /// <remarks/>
        public int PeriodStartYear { get; set; }

        /// <remarks/>
        public int PeriodEnd { get; set; }

        /// <remarks/>
        public int PeriodEndYear { get; set; }
    }
}