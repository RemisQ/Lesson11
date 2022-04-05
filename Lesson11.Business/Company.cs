using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Business
{
    public class Company
    {
        public string CompanyName { get; }
        public List<Country>Country { get; }
        public Company( string companyName, List<Country>country)
        {
            CompanyName = companyName;
            Country = country;
        }
    }
}
