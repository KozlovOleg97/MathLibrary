namespace MathLib.Utils
{
    public static class ValidationHelper
    {
        public static void ValidateCircleRadius(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be greater than zero.");
            }
        }

        public static void ValidateTriangleSides(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("All sides of a triangle must be greater than zero.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("The sum of any two sides of a triangle must be greater than the third side.");
            }
        }
    }
}
