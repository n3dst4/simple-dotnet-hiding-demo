using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food;
            Fruit fruit = new Banana();

            fruit.Name = "My Fruit";
            fruit.VirtualName = "My Virtual Fruit";

            food = fruit;

            food.Name = "My Food";
            food.VirtualName = "My Virtual Food";

            Console.WriteLine("fruit.Name: {0}", fruit.Name); // "My fruit"
            Console.WriteLine("food.Name: {0}", food.Name); // "My Food"

            Console.WriteLine("fruit.VirtualName: {0}", fruit.VirtualName); // "My Virtual Food"
            Console.WriteLine("food.VirtualName: {0}", food.VirtualName); // "My Virtual Food"
        }
    }
}
