using NLog;

namespace NLogConfiguration
{
    internal class Program
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Logger.Info("Test");
        }
    }
}
