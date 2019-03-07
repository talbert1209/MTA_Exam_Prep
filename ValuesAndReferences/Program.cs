using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuesAndReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point{X = 10, Y = 20};
            Point p2 = p1;
            p2.X = 100;

            Console.WriteLine($"p1.X = {p1.X}");

            Rectangle rect1 = new Rectangle{Lenght = 10.0, Width = 20.0};
            Rectangle rect2 = rect1;
            rect2.Lenght = 100.0;

            Console.WriteLine($"rect1.Length = {rect1.Lenght}");

        }

        struct Point
        {
            public double X, Y;
        }

        public class Rectangle
        {
            public static string ShapeName
            {
                get { return "Rectangle"; }
            }

            public double Lenght { get; set; }
            public double Width { get; set; }

            public double GetArea()
            {
                return Lenght * Width;
            }
        }
    }
}
