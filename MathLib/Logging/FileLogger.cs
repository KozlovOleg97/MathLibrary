using MathLib.Interfaces;

namespace MathLib.Logging
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            using (var writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"[LOG] {message} - {DateTime.Now}");
            }
        }
    }
}
