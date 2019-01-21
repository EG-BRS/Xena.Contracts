using System;
using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public abstract class EntityDto : FiscalDto, IEntityDto
    {
        public long? Id { get; set; }
        [ReadOnly(true)]
        public int Version { get; set; }
        [ReadOnly(true)]
        public bool IsDeactivated { get; set; }

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

    public interface IEntityDto : IHasIdDto
    {
        int Version { get; }
        bool IsDeactivated { get; }
    }
    public interface IHasIdDto
    {
        long? Id { get; }
    }
    public interface IHasUserIdDto
    {
        long UserId { get; set; }
    }
    public abstract class TransactionalDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public int Version { get; set; }
    }
    public abstract class ImportedDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public int Version { get; set; }
    }
    public abstract class FiscalDto
    {
        [ReadOnly(true)]
        public long FiscalSetupId { get; set; }
        [ReadOnly(true)]
        public DateTime CreatedAt { get; set; }
    }
}