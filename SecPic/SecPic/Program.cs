using System;

namespace SecPic
{
    class Program   //It is the 3rd program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Student s = new Student();
            //Console.WriteLine(s.Study());
            Console.WriteLine(t.Explain());
            t.Greet();

        }
    }
}
