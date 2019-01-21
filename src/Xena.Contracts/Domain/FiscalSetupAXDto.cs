using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class FiscalSetupAXDto : IHasIdDto
    {
        public long? Id { get; set; }
        public bool IsDeactivated { get; set; }
        public long? ProviderId { get; set; }
        public int? AccountNumber { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string PlaceName { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }
        public string CreatedAt { get; set; }
        public string PhoneNumber { get; set; }
        public string LastActive { get; set; }
        public string AdminUser { get; set; }
        public string OrgNumber { get; set; }
        public string DueType { get; set; }
        private string _dueTypeDescription = null;
        [ReadOnly(true)]
        public string DueTypeDescription
        {
            get
            {
                if (_dueTypeDescription != null)
                {
                    return _dueTypeDescription;
                }
                switch (DueType)
                {
                    case DueTypes.Xena_PrePaid:
                        return DueTypes.Xena_PrePaid.GetLocalizedDueType();
                    case DueTypes.Xena_Cash:
                        return DueTypes.Xena_Cash.GetLocalizedDueType();
                    case DueTypes.Xena_Nett:
                        return Offset == 0 ? DueTypes.Xena_Nett.GetLocalizedDueType() : string.Format(DueTypeDays.Xena_Nett_Days.GetLocalizedDueType(), Offset);
                }
                return Offset == 0 ? DueTypes.Xena_RunningMonth.GetLocalizedDueType() : string.Format(DueTypeDays.Xena_RunningMonth_Days.GetLocalizedDueType(), Offset);
            }
            set { _dueTypeDescription = value; }
        }

        public int Offset { get; set; }
        public string InvoiceEmail { get; set; }
    }
}