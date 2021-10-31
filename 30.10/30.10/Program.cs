using System;

namespace _30._10
{
    class Program //It is the 1st program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                brand = "mercedes benz",
                model = "e-250"
            };

            Console.WriteLine(car.BrandnModel());

            Console.Write("Please enter the capacity of the tank: ");
            int cap = int.Parse(Console.ReadLine());
            Console.WriteLine("You can drive "+car.FullTank(cap) + "km with full tank.");
        }
    }
}
