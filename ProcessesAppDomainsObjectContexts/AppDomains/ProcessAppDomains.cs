using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ProcessesAppDomainsObjectContexts.AppDomains
{
   class ProcessAppDomains
   {
      public ProcessAppDomains()
      {
         AppDomain current = AppDomain.CurrentDomain;
         current.ProcessExit += OnUnloadingCurrentAppDomain;
         ReadAppDomain( current );

         AppDomain randDomain = GetNewAppDomain("RandomAppDomain");
         randDomain.DomainUnload += OnDomainUnload;
         ReadAppDomain( randDomain );
         
         AppDomain.Unload(randDomain);
      }

      private void OnUnloadingCurrentAppDomain(object sender, EventArgs e)
      {
         Console.WriteLine( "Unloaded current app domain." );
      }

      private static void OnDomainUnload(object sender, EventArgs e)
      {
         Console.WriteLine("Unloaded random app domain.");
      }

      private AppDomain GetNewAppDomain( string Name )
      {
         return AppDomain.CreateDomain(Name);
      }

      private void ReadAppDomain( AppDomain appDomain )
      {
         Assembly[] loadedAssemblies = appDomain.GetAssemblies();
         Console.WriteLine( "*************** Assemblies in {0} ***************", appDomain.FriendlyName );
         foreach (Assembly assembly in loadedAssemblies)
         {
            Console.WriteLine( "->Name: {0}", assembly.GetName().Name );
            Console.WriteLine( "->Version: {0}\n", assembly.GetName().Version );
         }
      }
   }
}
