using System;

namespace ThirdPic
{
    class Program
    {
        static void Main(string[] args)
        {
            FindVolume fv = new FindVolume();
            Console.WriteLine("Volume of the given box - "+fv.VolumeOfBox(4,2,2));
        }
    }
}
