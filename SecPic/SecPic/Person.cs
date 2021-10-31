using System;
using System.Collections.Generic;
using System.Text;

namespace SecPic
{
    class Person
    {
        int age;

        public void Greet()
        {
            Console.WriteLine("Greetings!");
        }
        public void SetAge(int age) {
            this.age = age;
        }
    }
}
