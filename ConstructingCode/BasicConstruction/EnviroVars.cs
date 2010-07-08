using System;

namespace ConstructingCode.BasicConstruction
{
   class EnviroVars
   {
      public EnviroVars()
      {
         string[] enviroArgs = Environment.GetCommandLineArgs();

         foreach (string arg in enviroArgs)
            Console.WriteLine("Arg: {0}", arg);
      }
   }
}
