using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProcessesAppDomainsObjectContexts.Processes
{
   class StartStopProcess
   {
      public StartStopProcess()
      {
         Process ieProc = Process.Start("IExplore.exe", "www.ghostmonk.com");

         Console.WriteLine("-->Hit enter to stop {0}...", ieProc.ProcessName);
         Console.ReadLine();

         try
         {
            ieProc.Kill();
         }
         catch{}
      }
   }
}
