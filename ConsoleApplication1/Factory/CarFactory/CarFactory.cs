using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Factory
{
    public class CarFactory
    {
        public Vehicle MakeVehicle(String vehicleType)
        {

            switch (vehicleType.ToUpper())
            {
                case "B":
                    return new Bus();
                case "C":
                    return new Car();
                default:
                    return null;
            }
        }

        public void ChangeColour(Vehicle vehicle, string color)
        {
            vehicle.Colour = color;
        }
    }
}
