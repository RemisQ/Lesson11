using Lesson11.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.DataAccess
{
    public class AircraftModelRepository
    {
        private List<AircraftModel> aircraftModels { get; }

        public AircraftModelRepository()
        {
            aircraftModels = new List<AircraftModel>();
            aircraftModels.Add(new AircraftModel("T1-5505", "Very fast aircraft"));
            aircraftModels.Add(new AircraftModel("T2-4533", "Very slow aircraft"));
            aircraftModels.Add(new AircraftModel("T3-6642", "Very fast aircraft"));
        }
        public List<AircraftModel> Retrieve()
        {
            return aircraftModels;
        }
        public AircraftModel Retrieve(int number)
        {
            return aircraftModels[number];
        }
    }
}
