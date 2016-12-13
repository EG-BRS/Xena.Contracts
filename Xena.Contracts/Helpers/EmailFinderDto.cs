using System.Collections.Generic;
using System.Linq;
using Xena.Contracts.Domain;
using Xena.Resources;

namespace Xena.Contracts.Helpers
{
    public class EmailFinderDto : IHasIdDto
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string EmailOrigin { get; set; }
        public long? PartnerId { get; set; }
        public long? VCardId { get; set; }
        public long? UserId { get; set; }
        public long? ResourceId { get; set; }
        public long FiscalSetupId { get; set; }
        public string PartnerName { get; set; }
        public string Description => AllTypes.Contains(Name) 
            ? $"{PartnerName}, {Name.GetLocalizedConstant()} ({Email})"
            : $"{(string.IsNullOrEmpty(Name) ? PartnerName : $"{Name}, {PartnerName}")} ({Email})";

        public static IEnumerable<string> AllTypes => new[] { CustomerEmail, SupplierEmail };
        public const string CustomerEmail = "CustomerEmail";
        public const string SupplierEmail = "SupplierEmail";
    }
}