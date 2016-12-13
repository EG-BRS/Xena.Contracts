using System.Collections.Generic;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class PartnerResourceContextDto : EntityDto
    {
        public long? UserId { get; set; }
        public string EmailIdentifier { get; set; }
        public string SenderEmail { get; set; }
        public string SMSSender { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }

        public string APIKey { get; set; }
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string DepartmentDescription { get; set; }
        public string BearerDescription { get; set; }
        public string PurposeDescription { get; set; }
        public string DefaultWarehouseDescription { get; set; }
        public long? DepartmentId { get; set; }
        public long? BearerId { get; set; }
        public long? PurposeId { get; set; }
        public long? DefaultWarehouseId { get; set; }
        public long? LedgerId { get; set; }
        public string LedgerDescription { get; set; }
        public bool? MayBookkeepFinance { get; set; }
        public long PartnerId { get; set; }
        public long? WorkingHoursScheduleId { get; set; }
        public long? WorkScheduleDescription { get; set; }
        public string Theme { get; set; }
        public bool ShowInOrder { get; set; }
        public bool ShowInFinance { get; set; }
        public bool ShowInScheduling { get; set; }
        public IList<long> BreakSetupIds { get; set; }

        public string CountryDisplayName => CountryName.GetLocalizedCountryName();
        public string ThemeFriendly => Theme.GetLocalizedTheme();
    }
}