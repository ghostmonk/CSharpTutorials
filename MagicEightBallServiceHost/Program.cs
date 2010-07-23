using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using MagicEightBallServiceHost.HostBasics;
using MagicEightBallWcfService;

namespace MagicEightBallServiceHost
{
   class Program
   {
      static void Main( string[] args )
      {
         new HostingServices();
         Console.ReadLine();
      }
   }
}
