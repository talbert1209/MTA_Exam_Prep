using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proficiency_Assessment_1
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string productName, decimal productPrice)
        {
            Name = productName;
            Price = productPrice;
        }

        public override string ToString()
        {
            return $"Name = {Name}, Price = {Price:C}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product tv = new Product("Samsung 60 inch TV", 300M);
            Console.WriteLine(tv.ToString());
        }
    }
}
