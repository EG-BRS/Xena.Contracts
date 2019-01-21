namespace Xena.Contracts.Helpers
{
    public class InviteUserData
    {
        public string Email { get; set; }
        public string[] ChosenRoles { get; set; }
        public long? PartnerId { get; set; }
        public string Culture { get; set; }
        public long[] AppIds { get; set; }

    }
}