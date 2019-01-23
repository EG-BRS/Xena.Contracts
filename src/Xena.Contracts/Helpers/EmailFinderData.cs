using System.Collections.Generic;
using System.Linq;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class EmailFinderData 
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PartnerName { get; set; }
        private string _description = null;
        public string Description
        {
            get
            { return _description ?? (AllTypes.Contains(Name)
                ? $"{PartnerName}, {Name.GetLocalizedConstant()} ({Email})"
                : $"{(string.IsNullOrEmpty(Name) ? PartnerName : $"{Name}, {PartnerName}")} ({Email})");
            }
            set { _description = value; }
        }

        public static IEnumerable<string> AllTypes => new[] { CustomerEmail, SupplierEmail };
        public const string CustomerEmail = "CustomerEmail";
        public const string SupplierEmail = "SupplierEmail";
    }
}