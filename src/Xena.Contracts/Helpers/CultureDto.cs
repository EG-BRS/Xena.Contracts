using System.Globalization;

namespace Xena.Contracts.Helpers
{
    public class CultureDto
    {

        public CultureDto()
        {
        }

        public CultureDto(CultureInfo invariantCulture)
        {
            Culture = invariantCulture.Name;
            Name = invariantCulture.DisplayName;
        }

        public CultureDto(string culture, string name)
        {
            Culture = culture;
            Name = name;
        }

        public string Culture { get; }
        public string Name { get; }
    }
}