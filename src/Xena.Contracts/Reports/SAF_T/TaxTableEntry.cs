﻿using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class TaxTableEntry
    {

        /// <remarks/>
        public string TaxType { get; set; }

        /// <remarks/>
        public string Description { get; set; }

        /// <remarks/>
        public TaxCodeDetails TaxCodeDetails { get; set; }
    }
}