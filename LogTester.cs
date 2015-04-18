using System;
using System.Linq;
using log4net;
using ILog = LoggingExtensions.Logging.ILog;

namespace thisLogTester
{
    public class LogTester
    {

        //private static log4net.ILog logger = LogManager.GetLogger("any");
        private static ILog logger = LogExtensions.Log(typeof(LogTester));
        public LogTester()
        {
            logger = this.Log();
        }


        public void Start()
        {
            logger.Debug("message {0}", new Exception());

            this.Log().Debug("Context should be 'LogTester'");
            "any".Log().Debug("Context should be 'any'");
            typeof(LogTester).Log().Debug("Context should be 'LogTester'");
            typeof(SampleClass).Log().Debug("Context should be 'SampleClass'");
            typeof(SampleClass).ToString().Log().Debug("Context should be 'SampleClass'");
            var sampleClass = new SampleClass();
            sampleClass.Log().Debug("Context should be 'SampleClass'");
        }

        private static void TestSTatic()
        {

        }

        private class SampleClass
        {
            public override string ToString()
            {
                return "myName";
            }
        }
    }
}
