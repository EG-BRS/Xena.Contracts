using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Owner
    {

        /// <remarks/>
        public string RegistrationNumber { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool RegistrationNumberSpecified { get; set; }

        /// <remarks/>
        public string Name { get; set; }

        /// <remarks/>
        public Address Address { get; set; }

        /// <remarks/>
        public Contact Contact { get; set; }

        /// <remarks/>
        public string OwnerID { get; set; }

        /// <remarks/>
        public string AccountID { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool AccountIDSpecified { get; set; }
    }
}