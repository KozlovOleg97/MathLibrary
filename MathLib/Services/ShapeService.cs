using MathLib.Interfaces;

namespace MathLib.Services
{
    public class ShapeService
    {
        private readonly ILogger _logger;

        public ShapeService(ILogger logger)
        {
            _logger = logger;
        }

        public double CalculateShapeArea(IShape shape)
        {
            try
            {
                var area = shape.CalculateArea();
                _logger.Log($"Calculated area: {area}");
                return area;
            }
            catch (Exception ex)
            {
                _logger.Log($"Error calculating area: {ex.Message}");
                throw;
            }
        }
    }
}
