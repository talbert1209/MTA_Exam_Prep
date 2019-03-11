using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Polymorphism
{
    class Program
    {
        class Polygon
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing: Polygon");
            }
        }

        class Rectangle: Polygon
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing: Rectangle");
            }
        }

        class Triangle: Polygon
        {
            public new void Draw()
            {
                Console.WriteLine("Drawing: Triangle");
            }
        }
        static void Main(string[] args)
        {
            //List<Polygon> polygons = new List<Polygon>();
            //polygons.Add(new Polygon());
            //polygons.Add(new Rectangle());
            //polygons.Add(new Triangle());

            //foreach (var polygon in polygons)
            //{
            //    polygon.Draw();
            //}

            //Showing display vs new keywords
            var myTriangle = new Triangle();
            Polygon myPolygon = myTriangle;

            myPolygon.Draw();
            myTriangle.Draw();
        }
    }
}
