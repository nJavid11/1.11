using System;
using System.Collections.Generic;
using System.Text;

namespace _30._10
{
    class Car : Vehicle
    {

        public Car() : base()
        {
        }
        public Car(string brand, string model, string color) : base(brand, model, color)
        {
        }

        string fuelCapacity;
        string doorCount;
        double consumption = 0.1d;

        public double Consumption
        {
            get { return consumption; }
            set { this.consumption = value; }
        }



        public double FullTank(int captank)
        {
            double kmFullTank = captank / consumption;

            return kmFullTank;
        }

    }
}
