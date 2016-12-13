namespace Xena.Contracts.Domain
{
    public class TelephoneNumberDto
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public bool SMS { get; set; }
        public int Index { get; set; }
        public override string ToString()
        {
            return Number;
        }
    }
}