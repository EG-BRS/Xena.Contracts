using System;
using Xena.Common.Constants;
using Xena.Contracts.Domain;

namespace Xena.Contracts.ExtensionMethods
{
    public static class FiscalSetupDtoExtensions
    {
        public static bool IsAccountant(this FiscalSetupDto fiscalSetup)
        {
            return FiscalSetupTypes.Accountant.Equals(fiscalSetup.FiscalSetupType, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsFacade(this FiscalSetupDto fiscalSetup)
        {
            return FiscalSetupTypes.Facade.Equals(fiscalSetup.FiscalSetupType, StringComparison.OrdinalIgnoreCase);
        }
    }
}