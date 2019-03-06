using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.static_members
{
    class Program
    {
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
        static void Main(string[] args)
        {
            var rectangle = new Rectangle{Lenght = 10.0, Width = 20.0};
            Console.WriteLine($"Shape Name: {Rectangle.ShapeName}, Area: {rectangle.GetArea()}");
        }
    }
}
