using Aircompany.Models;
using Aircompany.Planes;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        private List<Plane> Planes { get; set; }

        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();
        }

        public List<T> GetPlanes<T>() where T : class
        {
            var answeredPlanes = new List<T>();

            foreach (var plane in Planes)
                if (plane.GetType() == typeof(T))
                    answeredPlanes.Add(plane as T);

            return answeredPlanes;
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            return GetPlanes<PassengerPlane>().OrderByDescending(x => x.PassengersCapacity).First();
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            return GetPlanes<MilitaryPlane>().Where(x => x.PlaneType == MilitaryType.Transport).ToList();
        }

        public Airport SortByMaxDistance()
        {
            return new Airport(Planes.OrderBy(w => w.PlaneMaxFlightDistance));
        }

        public Airport SortByMaxSpeed()
        {
            return new Airport(Planes.OrderBy(w => w.PlaneMaxSpeed));
        }

        public Airport SortByMaxLoadCapacity()
        {
            return new Airport(Planes.OrderBy(w => w.PlaneMaxLoadCapacity));
        }

        public IEnumerable<Plane> GetPlanes()
        {
            return Planes;
        }

        public override string ToString()
        {
            return $"Airport {{ planes = {string.Join(", ", Planes.Select(x => x.PlaneModel))} }}";
        }
    }
}
