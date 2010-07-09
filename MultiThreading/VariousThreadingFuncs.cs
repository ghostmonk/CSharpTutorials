using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace MultiThreading
{
    class VariousThreadingFuncs
    {
        private static void ExtractExecutingThread()
        {
            Thread thread = Thread.CurrentThread;
        }

        private static void ExtractAppDomainHostingThread()
        {
            AppDomain appDomain = Thread.GetDomain();
        }

        private static void ExtractCurrentThreadContext()
        {
            Context context = Thread.CurrentContext;
        }
    }
}
