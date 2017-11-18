using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1
{
    public interface ICar
    {
        string GetName();
        CarColor GetColor();
        string GetRegistrationNumber();
        string GetNumber();
        string GetModel();

        int GetYear();

        void Move(int speed);

    }

}
