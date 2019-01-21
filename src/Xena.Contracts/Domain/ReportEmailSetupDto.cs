using System;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ReportEmailSetupDto : EntityDto
    {
        public string Culture { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public string ReportModule { get; set; }

        //Convinience properties
        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get
            {
                return _cultureDisplayName ??
                       (!string.IsNullOrEmpty(Culture) ? Culture.GetLocalizedCultureName() : string.Empty);
            }
            set { _cultureDisplayName = value; }
        }
        private string _reportModuleFriendly = null;
        [ReadOnly(true)]
        public string ReportModuleFriendly
        {
            get
            {
                return _reportModuleFriendly ?? (!string.IsNullOrEmpty(ReportModule)
                           ? ReportModule.GetLocalizedReportName()
                           : string.Empty);
            }
            set { _reportModuleFriendly = value; }
        }
    }
}