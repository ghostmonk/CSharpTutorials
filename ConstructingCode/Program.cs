using System;
using ConstructingCode.AdvancedConstruction;
using ConstructingCode.BasicConstruction;

namespace ConstructingCode
{
   class Program
   {
      static int Main()
      {
         BasicConstruction();
         AdvancedConstruction();
         Console.ReadLine();
         return -1;
      }

      private static void BasicConstruction()
      {
         new EnviroVars();
         new BasicFunctionality();
         new DateFunctionality();
         new TypeConversions();
      }

      private static void AdvancedConstruction()
      {
         new ParamModifiers();
         new UsingOverloading();
         new ArrayManip();
         new EnumExercises();
         new StructureExercises();
         new NullableTypes();
      }
   }
}