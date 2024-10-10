using MathLib.Interfaces;
using MathLib.Utils;

namespace MathLib.Models
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidationHelper.ValidateTriangleSides(sideA, sideB, sideC);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            return GeometryHelper.CalculateTriangleArea(SideA, SideB, SideC);
        }
        public bool IsRightTriangle()
        {
            return GeometryHelper.IsRightTriangle(SideA, SideB, SideC);
        }
    }
}
