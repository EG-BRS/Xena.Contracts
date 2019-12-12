using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Customers
    {
        /// <remarks/>
        public Customer[] Customer { get; set; }
    }
}
