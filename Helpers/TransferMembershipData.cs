namespace Xena.Contracts.Helpers
{
    public class TransferMembershipData
    {
        public string Email { get; set; }
        public bool DeleteUser { get; set; }
        public long MembershipId { get; set; }
    }
}