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
        private List<AircraftModel> AircraftModel { get; }

        public AircraftModelRepository()
        {
            AircraftModel = new List<AircraftModel>();
            AircraftModel.Add(new AircraftModel("1", "Very fast aircraft"));
            AircraftModel.Add(new AircraftModel("2", "Very slow aircraft"));
            AircraftModel.Add(new AircraftModel("3", "Very fast aircraft"));
        }
        public List<AircraftModel> Retrieve()
        {
            return AircraftModel;
        }
    }
}
