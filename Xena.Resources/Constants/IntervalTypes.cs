namespace Xena.Resources.Constants
{
    public static class IntervalTypes
    {
        public const string Days = "IntervalType_Days"; 
        public const string Weeks = "IntervalType_Weeks"; 
        public const string Months = "IntervalType_Months"; 
        public const string Years = "IntervalType_Years"; 
        public static string[] All => new[] {Days, Weeks, Months, Years};
    }
}