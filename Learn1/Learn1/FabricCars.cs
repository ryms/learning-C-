using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1
{
    public class FabricCars
    {
        public static ICar createCar(string typeCar) {
            ICar car = null;
            switch (typeCar)
            {
                case "BMW":
                    car = new CarBMW();
                    break;
                case "Logan":
                    car = new CarLogan();
                    break;
                default:
                    break;
            }

            return car;
        }
    }
}
