using System;
using System.Collections.Generic;
using System.Text;

namespace Read
{
    class Stopwatch
    {
        public void start()
        {
            startTime = DateTime.Now;
        }

        public long stop()
        {
            TimeSpan duration = DateTime.Now - startTime;
            return (long)duration.TotalMilliseconds;
        }

        private DateTime startTime;
    }
}
