using Services.Interfaces;

namespace Services
{
    public class LoggingServices : ILoggingServices
    {

        private string _directoryPath = @"..\..\..\Errors";
        private string _errorFile = @"\text.txt";
        public LoggingServices()
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }

            if (!File.Exists(_directoryPath + _errorFile))
            {
                File.Create(_directoryPath + _errorFile).Close();
            }
        }

        public void LogError(string message)
        {
            using (StreamWriter writer = new StreamWriter(_directoryPath + _errorFile, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
