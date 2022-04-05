using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Business
{
    public class AirCraft
    {
        public string TailNumber { get; }
        public List<Model> Model { get; }
        public List<Company> Company { get; }
        public AirCraft(string tailNumber, List<Model>model, List<Company>company)
        {
            TailNumber = tailNumber;
            Model = model;
            Company = company;
        }
    }
}
