using System;
using System.Linq;
using log4net;
using LoggingExtensions.log4net;
using LoggingExtensions.Logging;

namespace thisLogTester
{
    static class Program
    {
        static void Main(string[] args)
        {
            Log.InitializeWith<Log4NetLog>();

            log4net.Config.XmlConfigurator.Configure();
            var logTester = new LogTester();
            logTester.Start();

            var perf = new LogPerfomance();
            var perfLog = LogManager.GetLogger("perfLogger");
            perf.RunPerformance(msg => perfLog.Debug(msg), 1000000);
            //perf.RunPerformance(msg => perfLog.Debug(msg), 1000000);
            //Console.ReadKey();
        }
    }
}
