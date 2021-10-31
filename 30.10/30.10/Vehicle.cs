using System;
using System.Collections.Generic;
using System.Text;

namespace _30._10
{
    class Vehicle
    {
        public string brand;
        public string model;
        string color;

        public Vehicle() { }
        public Vehicle(string brand, string model, string color)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
        }

        public string BrandnModel() {
            string str = $"The brand is {brand} and the model is {model}.";
            return str;
        }
    }
}
