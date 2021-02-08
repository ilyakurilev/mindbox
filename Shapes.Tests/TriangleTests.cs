using NUnit.Framework;

namespace Shapes.Tests
{
    using Exceptions;

    public class TriangleTests
    {
        [Test]
        public void Area_GivenTriangle_ShouldReturnCorrectArea()
        {
            var triangle = new Triangle(5, 5, 6);

            var area = triangle.Area();

            Assert.AreEqual(12, area);
        }

        [Test]
        public void IsRight_GivenRightTriangle_ShouldReturnTrue()
        {
            var triangle = new Triangle(3, 4, 5);

            var isRight = triangle.IsRigth();

            Assert.IsTrue(isRight);
        }

        [Test]
        public void IsRight_GivenNotRightTriangle_ShouldReturnFalse()
        {
            var triangle = new Triangle(3, 4, 6);

            var isRight = triangle.IsRigth();

            Assert.IsFalse(isRight);
        }

        [Test]
        public void TryCreateTriangleWithNotCorrectSides_ShouldRaiseNotTriangleException()
        {
            Assert.Catch<NotTriangleException>(() => new Triangle(2, 4, 6));
        }
    }
}