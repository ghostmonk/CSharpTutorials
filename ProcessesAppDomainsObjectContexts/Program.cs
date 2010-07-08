using System;
using System.Windows.Forms;
using ProcessesAppDomainsObjectContexts.AppDomains;
using ProcessesAppDomainsObjectContexts.Processes;

namespace ProcessesAppDomainsObjectContexts
{
   static class Program
   {
      static void Main(string[] args)
      {
         /*new EnumerateProcesses();
         new CheckProcessThreads();
         new StartStopProcess();*/
         MessageBox.Show("Load in Windows Forms");
         new ProcessAppDomains();
         Console.ReadLine();
      }
   }
}
