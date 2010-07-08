using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProcessesAppDomainsObjectContexts.Processes
{
   class EnumerateProcesses
   {
      public EnumerateProcesses()
      {
         Process[] runningProcs = Process.GetProcesses(".");

         foreach (Process runningProc in runningProcs)
         {
            string info = string.Format("-> PID: {0}\tName: {1}", runningProc.Id, runningProc.ProcessName);
            Console.WriteLine( info );
         }
         Console.WriteLine("****************************************\n");
      }
   }
}
