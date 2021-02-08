using NUnit.Framework;
using System;

namespace Shapes.Tests
{
    using Exceptions;

    public class CircleTests
    {
        [Test]
        public void Area_GivenCircle_ShouldReturnCorrectArea()
        {
            var circle = new Circle(5);

            var area = circle.Area();

            Assert.AreEqual(78.5, Math.Round(area, 1, MidpointRounding.ToZero));
        }

        [Test]
        public void TryCreateCircleWithNegativeRadius_ShouldRaiseNegativeOrZeroRadiusException()
        {
            Assert.Catch<NegativeOrZeroRadiusException>(() => new Circle(-5));
        }
    }
}
