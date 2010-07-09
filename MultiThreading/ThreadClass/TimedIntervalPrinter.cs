using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading.ThreadClass
{
    class TimedIntervalPrinter
    {
        private int Times;
        private int Interval;

        public TimedIntervalPrinter(int times, int interval)
        {
            Times = times;
            Interval = interval;
        }

        public void Execute()
        {
            Console.WriteLine("-> {0} is executing a timed printout", Thread.CurrentThread.Name);
            for (int i = 0; i < Times; i++)
            {
                Console.Write("{0}, ", i);
                Thread.Sleep(Interval);
            }
            Console.WriteLine();
        }
    }
}
