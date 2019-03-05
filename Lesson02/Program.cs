using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Changed += new EventHandler(Rectangle_Changed);
            rectangle.Changed += GetNewArea;
            rectangle.Length = 10;

        }

        static void Rectangle_Changed(object sender, EventArgs e)
        {
            Rectangle rectangle = (Rectangle) sender;
            Console.WriteLine($"Value Changed: Length = {rectangle.Length}");
        }

        static void GetNewArea(object sender, EventArgs e)
        {
            if (sender is Rectangle rectangle) Console.WriteLine($"The new area of the rectangle is: {rectangle.GetArea()}");
        }
    }
}
