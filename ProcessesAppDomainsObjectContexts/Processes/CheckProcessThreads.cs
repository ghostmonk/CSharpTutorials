using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProcessesAppDomainsObjectContexts.Processes
{
   class CheckProcessThreads
   {
      public CheckProcessThreads()
      {
         Process proc;

         try
         {
            Console.WriteLine("Insert Proc ID.");
            int procID = int.Parse(Console.ReadLine());
            proc = Process.GetProcessById( procID );
            WriteOutThreads(proc);
            WriteOutModules(proc);
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }
      }

      private void WriteOutThreads( Process proc )
      {
         Console.WriteLine("Threads for Process {0} are:", proc.ProcessName);
         ProcessThreadCollection threadCollection = proc.Threads;

         foreach (ProcessThread thread in threadCollection)
         {
            string info = string.Format("-> ThreadID: {0}\tStartTime {1}\tPriority {2}",
               thread.Id, thread.StartTime.ToShortTimeString(), thread.PriorityLevel);
            Console.WriteLine(info);
         }

         Console.WriteLine("**********************************************");
      }

      private void WriteOutModules( Process proc )
      {
         Console.WriteLine("Threads for Process {0} are:", proc.ProcessName);
         ProcessModuleCollection moduleCollection = proc.Modules;
         foreach (ProcessModule module in moduleCollection)
            Console.WriteLine("->Mod Name:{0}", module.ModuleName);
      }
   }
}
