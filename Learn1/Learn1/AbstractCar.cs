using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1
{
    public abstract class AbstractCar : ICar
    {
        private CarColor color;
        private string registrationNumber;
        private string number;
        private string model;
        private int year;

        public AbstractCar(CarColor color, string regNumber, string number, string model,
            int year) {
                this.color = color;
                this.registrationNumber = regNumber;
                this.number = number;
                this.year = year;
                this.model = model;
        }

        public abstract string GetName();
        public abstract void Move(int speed);

        public CarColor GetColor()
        {
            return color;
        }

        public string GetRegistrationNumber()
        {
            return registrationNumber;
        }

        public string GetNumber()
        {
            return number;
        }

        public string GetModel()
        {
            return model;
        }

        public int GetYear()
        {
            return year;
        }

    }
}
