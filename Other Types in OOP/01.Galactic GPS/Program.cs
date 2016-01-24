using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Galactic_GPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Location earth = new Location(18.037986, 100.870097, Planet.Earth);
            Location mars = new Location(0.536512, 140.35469, Planet.Mars);
            Location jupiter = new Location(87.22156,-12.35662,Planet.Jupiter);
            Location saturn = new Location(64.123698,26.47589,Planet.Saturn);

            Console.WriteLine(earth);
            Console.WriteLine(mars);
            Console.WriteLine(jupiter);
            Console.WriteLine(saturn);

        }
    }
}
