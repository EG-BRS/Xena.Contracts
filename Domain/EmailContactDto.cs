namespace Xena.Contracts.Domain
{
    public class EmailContactDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Index { get; set; }
        public override string ToString()
        {
            return Email;
        }
    }
}