namespace Xena.Contracts.Domain.DocumentRelated
{
    public class DocumentFolderDto : EntityDto
    {
        public string Name { get; set; }

        public int Index { get; set; }

        public string Tags { get; set; }

        public string EntityType { get; set; }

        public long EntityId { get; set; }
    }
}