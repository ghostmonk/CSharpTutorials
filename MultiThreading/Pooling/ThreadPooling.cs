using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MultiThreading.Concurrency;
using MultiThreading.ThreadClass;

namespace MultiThreading.Pooling
{
    class ThreadPooling
    {
        public ThreadPooling()
        {
            Console.WriteLine("***********Using the ThreadPool***********");
            Console.WriteLine("Currently Executing in Thread {0}", Thread.CurrentThread.ManagedThreadId);

            RandomIntervalPrinter printer = new RandomIntervalPrinter(10, 3);
            WaitCallback workItem = new WaitCallback(ExecutePrinter);

            for (int i = 0; i < 10; i++)
                ThreadPool.QueueUserWorkItem(workItem, printer);

            Console.WriteLine("All tasks queued");
        }

        private void ExecutePrinter(object printer)
        {
            RandomIntervalPrinter task = (RandomIntervalPrinter)printer;
            task.Execute();
        }
    }
}
