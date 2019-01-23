using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class PartnerHistoryEntryDto : EntityDto
    {
        public long? PartnerId { get; set; }
        public long ResourceId { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public string ResourceName { get; set; }
        public string EntryType { get; set; }
        private string _entryTypeTranslated = null;
        [ReadOnly(true)]
        public string EntryTypeTranslated
        {
            get
            {
                return _entryTypeTranslated ??
                       (string.IsNullOrEmpty(EntryType) ? string.Empty : EntryType.GetLocalizedConstant());
            }
            set { _entryTypeTranslated = value; }
        }
    }
}