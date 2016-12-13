namespace Xena.Contracts.Helpers
{
    public class CreateDocumentRelationData
    {
        public long DocumentId { get; set; }
        public long EntityId { get; set; }
        public string ChosenEntity { get; set; }
        public bool NewDocument { get; set; }
    }
}