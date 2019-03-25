namespace Xena.Contracts.ApiRoutes
{
    public class UserSettingsRoutes
    {
        /// <summary>"Api/UserSettings"</summary>
        public const string Base = "Api/UserSettings";

        /// <summary>"Api/UserSettings/Double"</summary>
        public const string BaseDouble = Base + "/Double";

        /// <summary>"Api/UserSettings/Long"</summary>
        public const string BaseLong = Base + "/Long";

        /// <summary>"Api/UserSettings/String"</summary>
        public const string BaseString = Base + "/String";

        /// <summary>"Api/UserSettings/Bool"</summary>
        public const string BaseBool = Base + "/Bool";

        /// <summary>""</summary>
        public const string GetList = "";

        /// <summary>"Double/{setting}"</summary>
        public const string GetDouble = "Double/{setting}";

        /// <summary>"Double/{setting}"</summary>
        public const string PutDouble = "Double/{setting}";

        /// <summary>"Long/{setting}"</summary>
        public const string GetLong = "Long/{setting}";

        /// <summary>"Long/{setting}"</summary>
        public const string PutLong = "Long/{setting}";

        /// <summary>"Bool/{setting}"</summary>
        public const string GetBool = "Bool/{setting}";

        /// <summary>"Bool/{setting}"</summary>
        public const string PutBool = "Bool/{setting}";

        /// <summary>"String/{setting}"</summary>
        public const string GetString = "String/{setting}";

        /// <summary>"String/{setting}"</summary>
        public const string PutString = "String/{setting}";

        /// <summary>"Bool"</summary>
        public const string PutBoolList = "Bool";
    }
}