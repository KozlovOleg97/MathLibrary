namespace MathLib.Utils
{
    public static class GeometryHelper
    {
        public static bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            return Math.Abs((sides[0] * sides[0]) + (sides[1] * sides[1]) - (sides[2] * sides[2])) < 0.0001;
        }

        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }
    }
}
