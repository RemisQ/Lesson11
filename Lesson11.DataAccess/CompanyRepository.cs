using Lesson11.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.DataAccess
{
    public class CompanyRepository
    {
        private List<Company> Companies { get; }

        public CompanyRepository()
        {
            Companies = new List<Company>();
            Companies.Add(new Company("Profitable", new Country("LT", "Lithuania")));
            Companies.Add(new Company("Not profitable", new Country("RU", "Russia")));
            Companies.Add(new Company("Profitable", new Country("CA", "Canada")));
        }
        public List<Company>Retrieve()
        {
            return Companies;
        }
    }
}
