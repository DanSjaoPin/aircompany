using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string PlaneModel;
        public int PlaneMaxSpeed;
        public int PlaneMaxFlightDistance;
        public int PlaneMaxLoadCapacity;

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            PlaneModel = model;
            PlaneMaxSpeed = maxSpeed;
            PlaneMaxFlightDistance = maxFlightDistance;
            PlaneMaxLoadCapacity = maxLoadCapacity;
        }


        public override string ToString()
        {
            return $@"Plane {{ Model = '{PlaneModel}', MaxSpeed = {PlaneMaxSpeed}, MaxFlightDistance = {PlaneMaxFlightDistance}, MaxLoadCapacity = {PlaneMaxLoadCapacity} }}";
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   PlaneModel == plane.PlaneModel &&
                   PlaneMaxSpeed == plane.PlaneMaxSpeed &&
                   PlaneMaxFlightDistance == plane.PlaneMaxFlightDistance &&
                   PlaneMaxLoadCapacity == plane.PlaneMaxLoadCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PlaneModel);
            hashCode = hashCode * -1521134295 + PlaneMaxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + PlaneMaxFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + PlaneMaxLoadCapacity.GetHashCode();
            return hashCode;
        }        

    }
}
