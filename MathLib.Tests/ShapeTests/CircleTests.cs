using MathLib.Models;

namespace MathLib.Tests.ShapeTests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_CalculateArea_ShouldReturnCorrectArea()
        {
            double radius = 5;
            var circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            var actualArea = circle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void Circle_CalculateArea_ShouldThrowArgumentException_WhenRadiusIsNegative()
        {
            double negativeRadius = -5;

            Assert.Throws<ArgumentException>(() => new Circle(negativeRadius));
        }
    }
}
