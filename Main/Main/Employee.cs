using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Employee
    {
        public string name;
        public string surname;
        public string position;
        public int dailySalary;

        public int MonthlySalary()
        {
            int monSalary = dailySalary * 30;
            return monSalary;

        }
    }
}
