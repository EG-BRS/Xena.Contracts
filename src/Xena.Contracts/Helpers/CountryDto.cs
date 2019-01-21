namespace Xena.Contracts.Helpers
{
    public class CountryDto
    {
        public CountryDto(){}

        public CountryDto(string abbreviation, string translatedName)
        {
            Abbreviation = abbreviation;
            TranslatedName = translatedName;
        }

        public string Abbreviation { get; }
        public string TranslatedName { get; }
    }
}