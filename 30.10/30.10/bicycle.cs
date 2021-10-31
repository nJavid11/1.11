using System;
using System.Collections.Generic;
using System.Text;

namespace _30._10
{
    class Bicycle : Vehicle
    {
        public Bicycle() : base()
        {
        }
        public Bicycle(string brand, string model, string color) : base(brand, model, color)
        {
        }

        int wheelSize;

        public int WheelSize
        {
            get { return this.wheelSize; }
            set { wheelSize = value; }
        }
    }
}
