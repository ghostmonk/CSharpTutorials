using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using MagicEightBallWcfService;

namespace MagicEightBallServiceHost.HostBasics
{
   class HostingServices
   {
      public HostingServices()
      {
         StartService();
      }

      private void StartService()
      {
         Console.WriteLine( "***** Console Based WCF Host *****" );
         using( ServiceHost serviceHost = new ServiceHost( typeof( MagicEightBallService ) ) )
         {
            serviceHost.Open();
            DisplayHostInfo( serviceHost );
            Console.WriteLine( "The Service is Ready" );
            Console.WriteLine( "Press the Enter key to terminate Service." );
            Console.ReadLine();
         }
         Console.WriteLine( "The Service has been terminated." );
      }

      private void DisplayHostInfo( ServiceHost host )
      {
         Uri address = host.BaseAddresses[0];
         Console.WriteLine();
         Console.WriteLine( "**********HOST INFO********" );
         Console.WriteLine( "Name: {0}", host.Description.ConfigurationName );
         Console.WriteLine( "Port: {0}", address.Port );
         Console.WriteLine( "LocalPath: {0}", address.LocalPath );
         Console.WriteLine( "Uri: {0}", address.AbsoluteUri );
         Console.WriteLine( "Scheme: {0}", address.Scheme );
         Console.WriteLine( "***************************" );
         Console.WriteLine();
      }
   }
}
