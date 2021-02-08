using System;

namespace Shapes
{
    using Exceptions;

    public class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;

        public double A { 
            get => _a;
            private set => _a = value > 0 ? value : throw new NegativeOrZeroSideException(nameof(A), value);
        }
        public double B {
            get => _b;
            private set => _b = value > 0 ? value : throw new NegativeOrZeroSideException(nameof(B), value);
        }
        public double C { 
            get => _c;
            private set => _c = value > 0 ? value : throw new NegativeOrZeroSideException(nameof(C), value);
        }


        public Triangle(int a, int b, int c)
        {
            if (!IsTriangle(a, b, c))
            {
                throw new NotTriangleException(a, b, c);
            }

            A = a;
            B = b;
            C = c;
        }

        public override double Area()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRigth() =>
            A * A + B * B == C * C ||
            A * A + C * C == B * B ||
            B * B + C * C == A * A;
        

        private bool IsTriangle(double a, double b, double c) =>
            a + b > c && 
            a + c > b && 
            b + c > a;  
    }
}
