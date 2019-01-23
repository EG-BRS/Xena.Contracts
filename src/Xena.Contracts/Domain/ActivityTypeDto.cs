using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ActivityTypeDto : EntityDto
    {
        public string ActivityTypeType { get; set; }

        private string _activityTypeTypeTranslated = null;
        [ReadOnly(true)]
        public string ActivityTypeTypeTranslated
        {
            get
            {
                return _activityTypeTypeTranslated ?? (string.IsNullOrEmpty(ActivityTypeType)
                           ? string.Empty
                           : ActivityTypeType.GetLocalizedConstant());
            }
            set { _activityTypeTypeTranslated = value; }
        }
        [Required]
        [StringLength(255)]
        public string Abbreviation { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        [StringLength(255)]
        public string Colour { get; set; }
        public long? ArticleId { get; set; }
        public bool IsBillable { get; set; }
        public bool IsAtWork { get; set; }
        public bool IsPaid { get; set; }
        public int? DefaultDurationHours { get; set; }
        public int? DefaultDurationMinutes { get; set; }
        public long? CostTypeId { get; set; }
        //Convinience properties

        [ReadOnly(true)]
        public string ArticleNumber { get; set; }
        [ReadOnly(true)]
        public string ArticleDescription { get; set; }
        [ReadOnly(true)]
        public string CostTypeDescription { get; set; }

        private string _defaultDurationFriendly;
        [ReadOnly(true)]
        public string DefaultDurationFriendly
        {
            get
            {
                return _defaultDurationFriendly ?? (DefaultDurationHours.HasValue
                           ? $"{DefaultDurationHours.Value:D2}:{(DefaultDurationMinutes ?? 0):D2}"
                           : string.Empty);
            }
            set { _defaultDurationFriendly = value; }
        }
    }
}