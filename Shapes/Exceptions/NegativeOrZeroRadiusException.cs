using System;

namespace Shapes.Exceptions
{
    public class NegativeOrZeroRadiusException : Exception
    {
        public double Radius { get; }

        public NegativeOrZeroRadiusException(double radius)
            : base($"Radius must be greater than zero: Radius = {radius}")
        {
            Radius = radius;
        }
    }
}
