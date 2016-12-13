using System;
using System.Globalization;
using System.Threading;

namespace Xena.Resources
{
    public static class ResourceExtensions
    {
        public static string GetLocalizedNotificationTypeDescription(this string notificationType, CultureInfo culture = null)
        {
            culture = culture ?? Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"{notificationType}_Description";
            return Constant.ResourceManager.GetString(localizedKey, culture);
        }
        public static string GetLocalizedCountryName(this string countryName)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_Country_{countryName}";
            return Countries.ResourceManager.GetString(localizedKey, currentCulture);
        }

        public static string GetLocalizedConstant(this string constant)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            return Constant.ResourceManager.GetString(constant, currentCulture);
        }
        public static string GetLocalizedCultureName(this string cultureName)
        {
            return new CultureInfo(cultureName).NativeName;
        }
        public static string GetLocalizedCurrencyName(this string currencyName)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_Currency_{currencyName}";
            return Currencies.ResourceManager.GetString(localizedKey, currentCulture);
        }
        public static string GetLocalizedEntityName(this string entityName)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_Entity_{entityName.Replace("Dto", "")}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }
        public static string GetLocalizedIdentityType(this string identityType)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_IdentityType_{identityType}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }
        public static string GetLocalizedDueType(this string dueType)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_DueType_{dueType}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }
        public static string GetLocalizedContextType(this string contextType)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_ContextType_{contextType}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }

        public static string GetLocalizedPartnerContextType(this string partnerContextType)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_PartnerContextType_{partnerContextType}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }
        public static string GetLocalizedRecipientAddressTypes(this string recipientAddressType)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_RecipientAddressType_{recipientAddressType}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }
        public static string GetLocalizedEnum(this Enum enumValue)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var lookup = $"{enumValue.GetType().Name}_{enumValue}";
            return Constant.ResourceManager.GetString(lookup, currentCulture);
        }
        public static string GetLocalizedReportName(this string reportGroup, CultureInfo currentCulture = null)
        {
            currentCulture = currentCulture ?? Thread.CurrentThread.CurrentUICulture;
            var lookup = $"Reports_DefaultName_{reportGroup}";
            return Constant.ResourceManager.GetString(lookup, currentCulture);
        }

        public static string GetLocalizedUserGroup(this string userGroup)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_UserGroup_{userGroup}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }

        public static string GetLocalizedIntervalType(this string intervalType , int? interval)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            if (interval.HasValue && interval.Value == 1)
                intervalType = intervalType.Substring(0, intervalType.Length - 1);

            var lookup = $"{intervalType}";
            return Constant.ResourceManager.GetString(lookup, currentCulture);
        }
        public static string GetLocalizedInventoryStatus(this string inventoryStatus)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_{inventoryStatus}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }

        public static string GetLocalizedTheme(this string theme)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_Theme_{ConvertTheme(theme)}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }

        public static string GetLocalizedDeliveryStatus(this string deliveryStatus)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_DeliveryStatus_{deliveryStatus}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }
        
        public static string GetLocalizedBookkeepingStatus(this string bookkeepingStatus)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var localizedKey = $"Localized_{bookkeepingStatus}";
            return Constant.ResourceManager.GetString(localizedKey, currentCulture);
        }

        private static string ConvertTheme(string theme)
        {
            switch (theme)
            {
                case "theme-1":
                    return "MintGreen";
                case "theme-2":
                    return "OceanBlue"; 
                case "theme-3":
                    return "Blue";
                case "theme-4":
                    return "NaviBlue";
                case "theme-5":
                    return "Purple";
                case "theme-6":
                    return "Prikly";
                case "theme-7":
                    return "Pink";
                case "theme-8":
                    return "Rusty";
                case "theme-9":
                    return "Dusty";
                case "theme-10":
                    return "Yellow";
                case "theme-11":
                    return "LightYellow";
                case "theme-12":
                    return "Coffee";
                case "theme-13":
                    return "Dark";
                default:
                    return "Standard";
            }
        }
    }


}