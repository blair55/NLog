using NLog;

namespace ConsoleApp
{
    class Program
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Log.Info("Log line 1");
            Log.Info("Log line 2");
            Log.Info("Log line 3");
        }
    }
}
