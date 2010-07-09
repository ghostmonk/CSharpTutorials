using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;

namespace FileIO.IsolatedStorage
{
   class EvidenceReader
   {
      public EvidenceReader()
      {
         bool isUserDone = false;
         string userOption = "";
         
         do
         {
            Console.WriteLine("L (load assembly) or Q (quit)");
            userOption = Console.ReadLine();

            if (userOption == "l")
               InitiateAssemblyLoad();
            else if (userOption == "q")
               isUserDone = true;
            else
               Console.WriteLine( "Not a valid input, please choose L or Q" );

         } while (!isUserDone);
      }

      private void InitiateAssemblyLoad()
      {
         Assembly assembly = LoadAssembly();
         if (assembly == null) return;
         DisplayEvidence(assembly);
      }

      private Assembly LoadAssembly()
      {
         string assemblyFolder = @"E:\Assemblies\";
         Console.WriteLine("Enter assembly File Name from {0}:", assemblyFolder);
         try
         {
            return Assembly.LoadFrom( assemblyFolder + Console.ReadLine() );
         }
         catch (Exception e)
         {
            Console.WriteLine( e.Message );
            return null;
         }
      }

      private void DisplayEvidence( Assembly assembly )
      {
         Evidence evidence = assembly.Evidence;
         IEnumerator itfEnum = evidence.GetHostEnumerator();

         while(itfEnum.MoveNext())
         {
            Console.WriteLine(" **** Press Enter to Continue **** ");
            Console.ReadLine();
            Console.WriteLine( itfEnum.Current );
         }
      }
   }
}
