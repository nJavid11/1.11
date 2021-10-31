using System;

namespace ThirdPic
{
    class Program   //It is the 4th program
    {
        static void Main(string[] args)
        {
            FindVolume fv = new FindVolume();
            Console.WriteLine("Volume of the given box - "+fv.VolumeOfBox(4,2,2));
        }
    }
}
