using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExternalAssemblyReflector
{
   class AssemblyReflector
   {
      public void LoadAndReadAssembly(string assemblyName)
      {
         Assembly assembly;

         try
         {
            assembly = Assembly.LoadFrom(assemblyName);
            DisplayTypesInAssembly(assembly);
         }
         catch(Exception e)
         {
            throw new Exception( "Sorry could not find assembly. Also: " + e.Message);
         }
      }

      private void DisplayTypesInAssembly( Assembly assembly )
      {
         Console.WriteLine("\n---------Types in Assembly--------");
         Console.WriteLine("-> {0}", assembly.FullName);
         foreach (Type type in assembly.GetTypes())
            Console.WriteLine("Type: {0}", type);
         Console.WriteLine();
      }
   }
}
