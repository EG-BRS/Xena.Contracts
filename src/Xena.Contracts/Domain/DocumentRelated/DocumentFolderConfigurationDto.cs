namespace Xena.Contracts.Domain.DocumentRelated
{
    public class DocumentFolderConfigurationDto : EntityDto
    {
        public string Name { get; set; }

        public int Order { get; set; }

        public string EntityType { get; set; }
    }
}