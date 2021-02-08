using Shapes;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new Shape[]
            {
                new Circle(5),
                new Triangle(2, 3, 4)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name} : {shape.Area()}");
             }
        }
    }
}
