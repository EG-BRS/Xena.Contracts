namespace Xena.Contracts.Domain
{
    public class ReportLayoutTextDto : EntityDto
    {
        public string DefaultText { get; set; }
        public string FriendlyText { get; set; }
        public string TextKey { get; set; }
        public bool Prompt { get; set; }
        public long ReportLayoutId { get; set; }
    }
}