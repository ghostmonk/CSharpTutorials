using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading.Concurrency
{
    class RandomIntervalPrinter
    {
        private int Times;
        private int Interval;
        private object ThreadLock = new object();

        public RandomIntervalPrinter(int times, int maxInterval)
        {
            Times = times;
            Interval = maxInterval;
        }

        public void Execute()
        {
            //Monitor.Enter(ThreadLock);
            lock (ThreadLock)
            //try
            {
                Console.WriteLine("-> {0} is executing a timed printout", Thread.CurrentThread.Name);
                for (int i = 0; i < Times; i++)
                {
                    Random rand = new Random();
                    Console.Write("{0}, ", i);
                    Thread.Sleep(1000 * rand.Next(Interval));
                }
                Console.WriteLine();
            }
            /*finally
            {
                Monitor.Exit(ThreadLock);
            }*/

        }
    }
}
