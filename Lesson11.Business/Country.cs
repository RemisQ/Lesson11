using System;

namespace Lesson11.Business
{
    public class Country
    {
        public string CountryCode { get; }
        public string CountryName { get; }

        public Country(string countryCode, string countryName)
        {
            CountryCode = countryCode;
            CountryName = countryName;
        }
    }
}
