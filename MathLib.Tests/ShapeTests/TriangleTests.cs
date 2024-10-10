using MathLib.Models;

namespace MathLib.Tests.ShapeTests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_CalculateArea_ShouldReturnCorrectArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

            var actualArea = triangle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void Triangle_CalculateArea_ShouldThrowArgumentException_WhenSidesAreInvalid()
        {
            double sideA = 1;
            double sideB = 2;
            double sideC = 10; 

            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldReturnTrue_ForRightTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5; 
            var triangle = new Triangle(sideA, sideB, sideC);

            var isRightTriangle = triangle.IsRightTriangle();

            Assert.True(isRightTriangle);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldReturnFalse_ForNonRightTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 6; 
            var triangle = new Triangle(sideA, sideB, sideC);

            var isRightTriangle = triangle.IsRightTriangle();

            Assert.False(isRightTriangle);
        }
    }
}
