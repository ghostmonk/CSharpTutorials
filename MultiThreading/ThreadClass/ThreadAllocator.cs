using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreading.ThreadClass
{
    class ThreadAllocator
    {
        string ThreadCount;

        public ThreadAllocator()
        {
            //ThreadChooser();
            ExecuteInBackground();
        }

        private void ThreadChooser()
        {
            Console.WriteLine("Choose [1] or [2] threads:");
            ThreadCount = Console.ReadLine();
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "PrimaryThread";
            Console.WriteLine("-> {0} is executing the ThreadAllocator", Thread.CurrentThread.Name);
            StartExecution();
            MessageBox.Show("I represent some other aspect of the UI");
        }

        private void ExecuteInBackground()
        {
            Console.WriteLine("******* Execute Thread in Background *******");
            ThreadCount = "1";
            Thread bgThread = new Thread(new ThreadStart(StartExecution));
            bgThread.IsBackground = true;
            bgThread.Start();
        }

        private void StartExecution()
        {
            TimedIntervalPrinter printer = new TimedIntervalPrinter(10, 2000);
            if (ThreadCount == "1")
            {
                printer.Execute();
            }
            else
            {
                if (ThreadCount != "2") Console.WriteLine("Do not recognize thread count... using 2 threads");
                Thread backgroundThread = new Thread(new ThreadStart(printer.Execute));
                backgroundThread.Name = "SecondaryThread";
                backgroundThread.Start();
            }
        }
    }
}
