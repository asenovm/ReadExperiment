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

        public int stop()
        {
            TimeSpan duration = DateTime.Now - startTime;
            return duration.Milliseconds;
        }

        private DateTime startTime;
    }
}
