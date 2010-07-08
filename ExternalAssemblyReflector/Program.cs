using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExternalAssemblyReflector
{
   class Program
   {
      static void Main(string[] args)
      {
         AssemblyReflector reflector = new AssemblyReflector();
         bool isDone = false;
         string assemblyName = "";
         do
         {
            Console.WriteLine("\nEnter an assembly to evaluate or enter Q to quit.");
            assemblyName = Console.ReadLine();

            if (assemblyName.ToUpper() == "Q")
            {
               isDone = true;
               break;
            }

            try
            {
               reflector.LoadAndReadAssembly(assemblyName);
            }
            catch (Exception exception)
            {
               Console.WriteLine(exception.Message);
            }

         } while (!isDone);
      }
   }
}
