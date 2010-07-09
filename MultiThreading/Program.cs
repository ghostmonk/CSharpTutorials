using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MultiThreading.SyncDelegate;
using MultiThreading.ThreadClass;
using System.Threading;
using MultiThreading.ParamThreadDelegate;
using MultiThreading.Concurrency;
using MultiThreading.Pooling;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //new BinaryOperation();
            //new ThreadStats( Thread.CurrentThread );
            //new ThreadAllocator();
            //new ParamThreads();
            //new ConcurrencyEmulator();
            //new InterlockedOperations();
            //new TimerCallbackExample();
            new ThreadPooling();
            Console.ReadLine();
        }
    }
}
