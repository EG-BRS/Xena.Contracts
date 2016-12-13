namespace Xena.Resources.Constants
{
    public static class ContextTypes
    {
        public static string[] All => new[] { Customer, Supplier };
        public const string Customer = "ContextType_Customer"; 
        public const string Supplier = "ContextType_Supplier"; 
    }
}