using Services.Interfaces;

namespace Services
{
    public class ExceptionServices : Exception
    {
        private string _message;
        private ILoggingServices loggingServices = new LoggingServices();
        private System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace();
       public new string Message
        {
            get => _message;
            set => _message = value;
        }


        public ExceptionServices(string messageEntered)
        {
            Message = messageEntered + stackTrace;
            loggingServices.LogError(Message);
        }
    }
}
