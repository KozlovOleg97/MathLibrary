using MathLib.Interfaces;
using MathLib.Utils;

namespace MathLib.Models
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            ValidationHelper.ValidateCircleRadius(radius);
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
