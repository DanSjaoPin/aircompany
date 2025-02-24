﻿using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType PlaneType;

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType planetype)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            PlaneType = planetype;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   PlaneType == plane.PlaneType;
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + PlaneType.GetHashCode();
            return hashCode;
        }

        public MilitaryType PlaneTypeIs()
        {
            return PlaneType;
        }


        public override string ToString()
        {
            return base.ToString().Replace("}", $", planeType = {PlaneType} }}");
        }        
    }
}
