using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1
{
    public class CarLogan : AbstractCar
    {
        private bool videoAdapter = false;

        public CarLogan()
            : base(CarColor.DarkRed, null, null, null, 0)
        { 

        }

        public CarLogan(CarColor color, string regNumber, string number, string model,
            int year, bool videoAdapter)
            :base(color,regNumber,number,model,year)
        {
                this.videoAdapter = videoAdapter;
        }


        override public string GetName()
        {
            return "Logan";
        }

        override public void Move(int speed)
        {
            Console.WriteLine(" Car Logan is moving with velocity = " + speed);
        }

        public bool hasVideoAdapter() 
        {
            return videoAdapter;
        }
    }
}
