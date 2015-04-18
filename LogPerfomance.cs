using System;
using System.Diagnostics;
using System.Linq;

namespace thisLogTester
{
    public class LogPerfomance
    {

        public void RunPerformance(Action<string> log, int count = 1000)
        {
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < count; i++)
                log(String.Format("Run {0}", i));

            sw.Stop();
            log(String.Format("Finished after {0:n}s", sw.Elapsed.TotalSeconds));
        }
    }
}
