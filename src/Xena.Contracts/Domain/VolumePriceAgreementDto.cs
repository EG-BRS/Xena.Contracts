using System.Collections.Generic;


namespace Xena.Contracts.Domain
{
    public class VolumePriceAgreementDto : EntityDto
    {
        public VolumePriceAgreementDto()
        {
            VolumeSteps = new List<VolumeStepDto>();
        }
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public int? ValidFromDays { get; set; }
        public int? ValidToDays { get; set; }
        public string ValidFromDaysFriendly { get; set; }
        public string ValidToDaysFriendly { get; set; }
        public string ContextType { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public long? PriceGroupId { get; set; }
        public string PriceGroupDescription { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public IList<VolumeStepDto> VolumeSteps { get; set; }
    }
}