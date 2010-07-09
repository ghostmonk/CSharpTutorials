using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading.Concurrency
{
    class ConcurrencyEmulator
    {
        public ConcurrencyEmulator()
        {
            Console.WriteLine("********Studying Concurrency Issues********");
            RandomIntervalPrinter printer = new RandomIntervalPrinter(10, 5);

            Thread[] threads = new Thread[10];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(printer.Execute));
                threads[i].Name = string.Format("Worker thread #{0}", i);
            }

            foreach (Thread thread in threads)
                thread.Start();
        }
    }
}
