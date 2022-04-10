using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Business
{
    public class AircraftModel
    {
        public string Number { get; }
        public string Description { get; }
        public AircraftModel( string number, string description)
        {
            Number = number;
            Description = description;
        }
    }
}
