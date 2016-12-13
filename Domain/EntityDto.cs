using System;

namespace Xena.Contracts.Domain
{
    public abstract class EntityDto : FiscalDto,IEntityDto
    {
        public long? Id { get; set; }
        public int Version { get; set; }
        public bool IsDeactivated { get; set; }
    }

    public interface IEntityDto:IHasIdDto
    {
        int Version { get; set; }
        bool IsDeactivated { get; set; }
    }
    public interface IHasIdDto
    {
        long? Id { get; set; }
    }
    public interface IHasUserIdDto
    {
        long UserId { get; set; }
    }
    public abstract class TransactionalDto:FiscalDto,IHasIdDto
    {
        public long? Id { get; set; }
        public int Version { get; set; }
    }
    public abstract class ImportedDto:FiscalDto,IHasIdDto
    {
        public long? Id { get; set; }
        public int Version { get; set; }
    }
    public abstract class FiscalDto
    {
        public long FiscalSetupId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}