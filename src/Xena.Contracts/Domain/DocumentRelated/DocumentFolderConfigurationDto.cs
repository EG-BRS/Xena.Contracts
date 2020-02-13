namespace Xena.Contracts.Domain.DocumentRelated
{
    public class DocumentFolderConfigurationDto : EntityDto
    {
        public string Name { get; set; }

        public string Tags { get; set; }

        public string DocumentFolderType { get; set; }
    }
}