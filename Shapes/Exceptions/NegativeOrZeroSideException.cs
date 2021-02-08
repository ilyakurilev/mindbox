using System;

namespace Shapes.Exceptions
{
    public class NegativeOrZeroSideException : Exception
    {
        public string Side { get; }
        public double SideValue { get; }

        public NegativeOrZeroSideException(string side, double sideValue)
            : base($"Side {side} must be greater than zero : {side} = {sideValue}")
        {
            Side = side;
            SideValue = sideValue;
        }
    }
}
