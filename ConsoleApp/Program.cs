using Shapes;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Shapess = new Shape[]
            {
                new Circle(5),
                new Triangle(2, 3, 4)
            };

            foreach (var Shapes in Shapess)
            {
                Console.WriteLine($"Area of {Shapes.GetType().Name} : {Shapes.Area()}");
             }
        }
    }
}
