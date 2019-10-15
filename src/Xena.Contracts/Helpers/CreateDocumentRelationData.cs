namespace Xena.Contracts.Helpers
{
    public class CreateDocumentRelationData
    {
        public long DocumentId { get; set; }
        public long? DocumentFolderId { get; set; }
        public long EntityId { get; set; }
        public string ChosenEntity { get; set; }
        public bool NewDocument { get; set; }
        public long? ExistingRelationId { get; set; }
        public string ExistingRelationType { get; set; }
    }
}