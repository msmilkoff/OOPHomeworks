using System;

namespace _01.GalacticGPS
{
    class GalacticGPS
    {
        static void Main()
        {
            Location some = new Location(15.037986, 100.0321, Planet.Mars);
            Console.WriteLine(some);
        }
    }
}
