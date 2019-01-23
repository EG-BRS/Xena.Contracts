using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class PartnerGLNNumberDto : EntityDto
    {
        public long PartnerId { get; set; }
        public string Description { get; set; }
        public string Attention { get; set; }
        public string GLN { get; set; }
        [ReadOnly(true)]
        public string PartnerName { get; set; }
    }
}