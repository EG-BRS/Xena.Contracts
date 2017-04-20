namespace Xena.Contracts.Domain
{
    public class AbsenceTypeDto : EntityDto
    {
        public string Description { get; set; }
        public string Colour { get; set; }
        public bool Paid { get; set; }

        public bool IsPaid { get; set; }
    }
}