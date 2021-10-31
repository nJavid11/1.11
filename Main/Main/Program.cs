using System;

namespace Main
{
    class Program   //It is the 2nd program
    {
        static void Main(string[] args)
        {
            Employee ep = new Employee()
            {
                name = "Javid",
                surname = "Namazov",
                position = "senior mobile app developer",
                dailySalary = 416
            };
            Console.WriteLine("Monthly salary of the employee: "+ep.MonthlySalary()+"$");
        }
}
}
