using System;

namespace SecPic
{
    class Program
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
