namespace Xena.Contracts.Domain
{
    public class DimensionsDto
    {
        public long? DepartmentId { get; set; }
        public long? BearerId { get; set; }
        public long? PurposeId { get; set; }

        protected bool Equals(DimensionsDto other)
        {
            return DepartmentId == other.DepartmentId && BearerId == other.BearerId && PurposeId == other.PurposeId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((DimensionsDto) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = DepartmentId.GetHashCode();
                hashCode = (hashCode * 397) ^ BearerId.GetHashCode();
                hashCode = (hashCode * 397) ^ PurposeId.GetHashCode();
                return hashCode;
            }
        }
    }
}