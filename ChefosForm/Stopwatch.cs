using System;
using System.Collections.Generic;
using System.Text;

namespace Read
{
    class Stopwatch
    {
        private DateTime startTime;

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public long Stop()
        {
            TimeSpan duration = DateTime.Now - startTime;
            return (long)duration.TotalMilliseconds;
        }
    }
}
