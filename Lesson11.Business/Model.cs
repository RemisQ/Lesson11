using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Business
{
    public class Model
    {
        public string AirCraftNumber { get; }
        public string AirCraftDescription { get; }
        public Model( string airCraftNumber, string airCraftDescription)
        {
            AirCraftNumber = airCraftNumber;
            AirCraftDescription = airCraftDescription;
        }
    }
}
