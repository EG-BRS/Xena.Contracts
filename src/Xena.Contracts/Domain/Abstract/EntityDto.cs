using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public abstract class EntityDto : FiscalDto, IEntityDto
    {
        public long? Id { get; set; }
        [ReadOnly(true)] public int Version { get; set; }
        [ReadOnly(true)] public bool IsDeactivated { get; set; }

        protected bool Equals(EntityDto other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(null, obj) ||
                !(obj is IHasIdDto))
            {
                return false;
            }

            var entity = (IHasIdDto)obj;
            if (!Id.HasValue || !entity.Id.HasValue)
                return false;
            return Id.Equals(entity.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}