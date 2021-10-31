using System;
using System.Collections.Generic;
using System.Text;

namespace SecPic
{
    class Student : Person
    {
        int age=18;

        public int Age {
            get { return age;}
            set { age = value;}
        }
        public string Study()
        {
            return "I'm studying";
        }

        public string ShowAge()
        {
            return $"I am {age} years old";
        }

    }
}
