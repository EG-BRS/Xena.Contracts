namespace Xena.Contracts.Helpers
{
    public class InviteUserData
    {
        public string Email { get; set; }
        public string[] ChosenRoles { get; set; }
        public long? PartnerId { get; set; }
        public bool SkipRegistration { get; set; }
    }
}