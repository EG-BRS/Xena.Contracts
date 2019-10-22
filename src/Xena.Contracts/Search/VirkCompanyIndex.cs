namespace Xena.Contracts.Search
{
    public class Kommune
    {
        public string KommuneNavn { get; set; }
    }
    public class NyesteBeliggenhedsadresse
    {
        public string Vejnavn { get; set; }
        
        public string HusnummerFra { get; set; }
        
        public string HusnummerTil { get; set; }
        
        public string Postnummer { get; set; }
        
        public string Postdistrikt { get; set; }
        
        public Kommune Kommune { get; set; }
    }
    public class NyesteNavn
    {
        public string Navn { get; set; }
    }
    
    public class VirksomhedMetadata
    {
        public NyesteNavn NyesteNavn { get; set; }
        
        public NyesteBeliggenhedsadresse NyesteBeliggenhedsadresse { get; set; }
    }
    public class Vrvirksomhed
    {
        public string CvrNummer { get; set; }
        
        public VirksomhedMetadata VirksomhedMetadata { get; set; }
    }
    public class VirkCompanyIndex
    {
        public Vrvirksomhed Vrvirksomhed { get; set; }
    }
}