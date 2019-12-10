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
        public byte PeriodStart { get; set; }

        /// <remarks/>
        public ushort PeriodStartYear { get; set; }

        /// <remarks/>
        public byte PeriodEnd { get; set; }

        /// <remarks/>
        public ushort PeriodEndYear { get; set; }
    }
}