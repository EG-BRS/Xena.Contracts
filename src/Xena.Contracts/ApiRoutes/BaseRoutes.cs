namespace Xena.Contracts.ApiRoutes
{
    public abstract class BaseRoutes
    {
        /// <summary>""</summary>
        public const string Post = "";

        /// <summary>"{id}"</summary>
        public const string Get = "{id}";

        /// <summary>""</summary>
        public const string GetList = "";

        /// <summary>"{id}"</summary>
        public const string Put = "{id}";

        /// <summary>"{id}"</summary>
        public const string Delete = "{id}";

        protected const string BaseFiscalUri = "~/Api/Fiscal/{fiscalId}/";
    }
}