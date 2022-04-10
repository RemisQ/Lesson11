using Lesson11.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.DataAccess
{
    public class CountryRepository
    {
        private List<Country> Countries { get; }
        private List<Country> EuropeCountries { get; }
        public CountryRepository()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country("LT", "Lietuva"));
            countries.Add(new Country("RU", "Russia"));
            countries.Add(new Country("CA", "Canada"));
            Countries = countries;

            List<Country> europeCountries = new List<Country>();
            europeCountries.Add(new Country("EE", "Estonia"));
            europeCountries.Add(new Country("LV", "Latvia"));
            europeCountries.Add(new Country("CZ", "Czechia"));
            europeCountries.Add(new Country("DK", "Denmark"));
            europeCountries.Add(new Country("SE", "Sweden"));
            europeCountries.Add(new Country("PL", "Poland"));
            europeCountries.Add(new Country("FR", "France"));
            EuropeCountries = europeCountries;
        }
        public bool IsCountryInEurope(string code)
        {
            return EuropeCountries.Any(item => item.Code == code);
        }
        public List<Country>Retrieve()
        {
            return Countries;
        }
        public Country Retrieve(int number)
        {
            return Countries[number];
        }
    }
}
