using System;

namespace Shapes
{
    using Exceptions;

    public class Circle : Shape
    {
        private double _radius;
        public double Radius {
            get => _radius;
            private set => _radius = value > 0 ? value : throw new NegativeOrZeroRadiusException(value);
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area() =>
            Math.PI * Radius * Radius;

    }
}
