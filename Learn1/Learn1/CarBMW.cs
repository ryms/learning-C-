using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1
{
    public class CarBMW : AbstractCar
    {
        private bool musicAdapter = false;

        public CarBMW():base(CarColor.DarkRed, null, null,null,0) { 

        }
        public CarBMW(CarColor color, string regNumber, string number, string model,
            int year, bool musicAdapter)
            : base(color, regNumber, number, model, year)
        {
            this.musicAdapter = musicAdapter;
        }

        override public string GetName()
        {
            return "BMW+";
        }

        override public void Move(int speed)
        {
            Console.WriteLine(" Car BMW is moving with velocity = " + speed);
        }

        public bool hasMusicAdapter() 
        {
            return musicAdapter;
        }
    }
}
