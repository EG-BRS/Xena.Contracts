using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Xena.Contracts.Domain;
using Xena.Contracts.Helpers;

namespace Xena.Contracts.Reports
{
    public class ReportDto
    {
        public ReportDto(ReportBodyDto body, FiscalSetupDto fiscalSetup, Stream logo, Dictionary<string, string> extras, CultureInfo culture, XDocument metaData = null)
        {
            Body = body;
            FiscalSetup = fiscalSetup;
            Logo = logo;
            Extras = extras;
            if(metaData == null)
            {
                metaData = XDocument.Parse("<Root/>");
            }
            MetaData = metaData;
            Culture = culture;
        }
        public XDocument MetaData { get; private set; }
        public Dictionary<string, string> Extras { get; private set; }
        public ReportBodyDto Body { get; private set; }
        public FiscalSetupDto FiscalSetup { get; private set; }
        public Stream Logo { get; private set; }
        public CultureInfo Culture { get; private set; }
    }
    public class ReportBodyDto
    {
        public object Criteria { get; set; }
        public object Data { get; set; }
    }
}