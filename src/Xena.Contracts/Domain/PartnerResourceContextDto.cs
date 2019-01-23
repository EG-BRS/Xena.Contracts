using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class PartnerResourceContextDto : EntityDto
    {
        public int? EndEmployment { get; set; }
        [ReadOnly(true)]
        public long? UserId { get; set; }
        [ReadOnly(true)]
        public string EmailIdentifier { get; set; }
        public string SenderEmail { get; set; }
        public string SMSSender { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }

        [ReadOnly(true)]
        public string APIKey { get; set; }
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        [Required]
        public string Name { get; set; }
        public string Alias { get; set; }
        public long? DepartmentId { get; set; }
        public long? BearerId { get; set; }
        public long? PurposeId { get; set; }
        public long? DefaultWarehouseId { get; set; }
        public long? LedgerId { get; set; }
        public bool? MayBookkeepFinance { get; set; }
        public long PartnerId { get; set; }
        public long? WorkingHoursScheduleId { get; set; }
        public string Theme { get; set; }
        public bool ShowInOrder { get; set; }
        public bool ShowInFinance { get; set; }
        public bool ShowInScheduling { get; set; }
        public IList<long> BreakSetupIds { get; set; }

        public string WorkPhone { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string LedgerDescription { get; set; }
        [ReadOnly(true)]
        public string WorkScheduleDescription { get; set; }
        [ReadOnly(true)]
        public string DepartmentDescription { get; set; }
        [ReadOnly(true)]
        public string BearerDescription { get; set; }
        [ReadOnly(true)]
        public string PurposeDescription { get; set; }
        [ReadOnly(true)]
        public string DefaultWarehouseDescription { get; set; }
        private string _countryDisplayName = null;
        [ReadOnly(true)]
        public string CountryDisplayName
        {
            get { return _countryDisplayName ?? CountryName.GetLocalizedCountryName(); }
            set { _countryDisplayName = value; }
        }
        private string _themeFriendly = null;
        [ReadOnly(true)]
        public string ThemeFriendly
        {
            get { return _themeFriendly ?? Theme.GetLocalizedTheme(); }
            set { _themeFriendly = value; }
        }
        [ReadOnly(true)]
        public IList<string> Tags { get; set; }
        public IList<ResourceTeamDto> Teams { get; set; }
    }
}