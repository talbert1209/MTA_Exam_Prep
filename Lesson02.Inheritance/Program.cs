using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Inheritance
{
    class Program
    {
        public abstract class Polygon
        {
            public double Length { get; protected set; }
            public double Width { get; protected set; }
            public abstract double GetArea();

        }

        public class Rectangle : Polygon
        {
            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
            }

            public override double GetArea()
            {
                return Length * Width;
            }

            public override string ToString()
            {
                return string.Format($"Width = {Width}, Length = {Length}, Area = {GetArea()}");
            }
        }

        public class Triangle: Polygon
        {
            public Triangle(double length, double width)
            {
                Width = width;
                Length = length;
            }
            public override double GetArea()
            {
                return (Length * Width) / 2;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10.0, 20.0);
            Triangle triangle = new Triangle(10.0, 20.0);

            Console.WriteLine($"Rectangle Area = {rectangle.GetArea()}");
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine($"Triangle Area = {triangle.GetArea()}");
        }

    }
}
