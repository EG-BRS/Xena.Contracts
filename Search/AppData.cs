namespace Xena.Contracts.Search
{
    public class AppData
    {
        public string Id => $"{XenaAppId}_{FiscalSetupId}_{EntityType}_{EntityId}";
        public long XenaAppId { get; set; }
        public long FiscalSetupId { get; set; }
        public string EntityType { get; set; }
        public long EntityId { get; set; }
        public object Data { get; set; }

        protected bool Equals(AppData other)
        {
            return XenaAppId == other.XenaAppId && FiscalSetupId == other.FiscalSetupId && string.Equals(EntityType, other.EntityType) && EntityId == other.EntityId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((AppData) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = XenaAppId.GetHashCode();
                hashCode = (hashCode*397) ^ FiscalSetupId.GetHashCode();
                hashCode = (hashCode*397) ^ (EntityType != null ? EntityType.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ EntityId.GetHashCode();
                return hashCode;
            }
        }
    }
}