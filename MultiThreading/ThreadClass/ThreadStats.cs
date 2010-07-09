using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading.ThreadClass
{
    class ThreadStats
    {
        public ThreadStats( Thread thread )
        {
            Console.WriteLine("********Current Thread Stats********");
            thread.Name = "PrimaryThread";
            Console.WriteLine("Current AppDomain Friendly Name = {0}", Thread.GetDomain().FriendlyName);
            Console.WriteLine("Current Context ID = {0}", Thread.CurrentContext.ContextID);
            ReadThreadStats(thread);
        }

        static private void ReadThreadStats(Thread thread)
        {
            Console.WriteLine("Current Thread Name = {0}", thread.Name);
            Console.WriteLine("Has Thread Started = {0}", thread.IsAlive);
            Console.WriteLine("Thread Priority Level = {0}", thread.Priority);
            Console.WriteLine("Thread State = {0}", thread.ThreadState);
        }
    }
}
