using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICar car = new ICar();
            //ICar carBmw = new CarBMW(CarColor.Blue, "123456789", "PX-MM25", "MX1", 2017, true);
          
           // ICar carLogan = new CarLogan(CarColor.White, "65478898", "PFD-254", "XXM", 2015, false);
            ICar car1 = FabricCars.createCar("BMW");
            ICar car2 = FabricCars.createCar("Logan");

            // carLogan.set

            Console.WriteLine("Car name = " + car1.GetName());
            Console.WriteLine("Car name = " + car2.GetName());

           // Console.WriteLine("Car has music adapter = " + carBmw.hasMusicAdapter());


            Console.WriteLine(" press any key to exit");
            Console.ReadKey();

        }
    }
}
