using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsGenerics.CollectionsGenerics.Generics
{
   class GenericMethods
   {
      public static void Swap<T>( ref T a, ref T b )
      {
         T temp = a;
         a = b;
         b = temp;
      }

      public static void DisplayBaseClass<T>()
      {
         Console.WriteLine("Base class of {0} is: {1}.", typeof(T), typeof(T).BaseType);
      }
   }
}
