using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Competency_Assessment_2
{
    class Program
    {
        struct Location
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public Location(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }
        static void Main(string[] args)
        {
            var heroLocation = new Location(12, 30, 60);

            Console.WriteLine($"The hero is located at X: {heroLocation.X} Y: {heroLocation.Y} Z: {heroLocation.Z}");
        }
    }
}
