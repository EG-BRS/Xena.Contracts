namespace Xena.Contracts.Helpers
{
    public class CurrencyDto
    {
        public string CurrencyEnglishName { get; set; }
        public string ISOCurrencySymbol { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyDisplayName { get; set; }

        protected bool Equals(CurrencyDto other)
        {
            return string.Equals(ISOCurrencySymbol, other.ISOCurrencySymbol);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((CurrencyDto) obj);
        }

        public override int GetHashCode()
        {
            return (ISOCurrencySymbol != null ? ISOCurrencySymbol.GetHashCode() : 0);
        }
    }
}