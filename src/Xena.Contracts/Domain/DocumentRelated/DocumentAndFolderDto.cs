using System;

namespace Xena.Contracts.Domain.DocumentRelated
{
    public class DocumentAndFolderDto
    {
        public bool IsFolder { get; set; }

        public long? Id { get; set; }

        public string Name { get; set; }

        public DateTime? Date { get; set; }

        public int? Size { get; set; }

        public DocumentAndFolderDto(DocumentFolderDto documentFolder)
        {
            IsFolder = true;
            Id = documentFolder.Id;
            Name = documentFolder.Name;
            Date = null;
            Size = null;
        }

        public DocumentAndFolderDto(DocumentDto document)
        {
            IsFolder = false;
            Id = document.Id;
            Name = document.LastFileName;
            Date = document.LastCreated;
            Size = document.LastContentLength;
        }
    }
}