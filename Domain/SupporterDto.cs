namespace Xena.Contracts.Domain
{
    public class SupporterDto:IEntityDto
    {
        public string FiscalSetupName { get; set; }
        public long? VCardId { get; set; }
        public long? PictureLastVersionId { get; set; }
        public string PictureUrl => PictureLastVersionId.HasValue && VCardId.HasValue
            ? $"/Blob/Public/VCard/{VCardId}/{PictureLastVersionId}/MenuThumbnail"
            : "/Content/images/avatar-company-xena.jpg";

        public long OnBehalfOfResourceId { get; set; }
        public string OnBehalfOfResourceTheme { get; set; }
        public string OnBehalfOfName { get; set; }
        public long XenaSupporterId { get; set; }
        public string XenaSupporterName { get; set; }
        public string XenaSupporterEmail { get; set; }
        public long OnBehalfOfId { get; set; }
        public long FiscalSetupId { get; set; }
        public long? Id { get; set; }
        public int Version { get; set; }
        public bool IsDeactivated { get; set; }
    }
}