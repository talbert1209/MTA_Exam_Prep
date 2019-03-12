using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competency_Assessment_1
{
    internal class Program
    {
        private class Product
        {
            private string _name;

            public string Name
            {
                get => _name;
                set
                {
                    if (string.IsNullOrEmpty(value)) throw new ArgumentNullException();

                    _name = value;
                }
            }
        }

        private static void Main(string[] args)
        {
            var myProduct = new Product();
            try
            {
                myProduct.Name = null;
                Console.WriteLine($"This is a {myProduct.Name}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"You can't do that, man! {e.Message}");
            }
        }
    }
}
