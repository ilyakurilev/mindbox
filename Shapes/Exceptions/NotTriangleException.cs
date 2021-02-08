using System;

namespace Shapes.Exceptions
{
    public class NotTriangleException : Exception
    {
        public NotTriangleException(double A, double B, double C)
            : base($"Triangle with sides {A}, {B}, {C} is not a triangle")
        {

        }
    }
}
