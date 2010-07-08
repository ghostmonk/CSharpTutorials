using System;
using System.Reflection;

namespace LangFeatures.LanguageFeature2008
{
   static class ExtensionMethods
   {
      public static void DisplayDefiningAssembly( this object obj )
      {
         Console.WriteLine("{0} lives here:\n\t->{1}\n", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()));
      }

      public static int ReverseDigits(this int i)
      {
         char[] digits = i.ToString().ToCharArray();
         Array.Reverse(digits);
         string newDigits = new string(digits);
         return int.Parse(newDigits);
      }

      public static void Foo( this int i)
      {
         Console.WriteLine("{0} called the Foo() method.", i);
      }

      public static void Foo( this int i, string msg )
      {
         Console.WriteLine("{0} called the Foo() method, saying {1}", i, msg);
      }
   }
}