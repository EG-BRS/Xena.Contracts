using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class XenaUserResourceDto : XenaUserDto
    {
        public string Name { get; set; }
    }

    public class XenaBookkeepingAccessDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long? LedgerId { get; set; }
        public bool IsAccountant { get; set; }

        private bool? _canBookkeep = null;
        [ReadOnly(true)]
        public bool CanBookkeep
        {
            get { return _canBookkeep ?? LedgerId.HasValue; }
            set { _canBookkeep = value; }
        }
    }
}