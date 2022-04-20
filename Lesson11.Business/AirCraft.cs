using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Business
{
    public class Aircraft
    {
        public int TailNumber { get; }
        public AircraftModel Model { get; }
        public Company Company { get; }
        public Aircraft(int tailNumber, AircraftModel model, Company company)
        {
            TailNumber = tailNumber;
            Model = model;
            Company = company;
        }
    }
}
