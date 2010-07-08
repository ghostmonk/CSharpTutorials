using System;
using LangFeatures.LanguageFeature2008.partialMethods;

namespace LangFeatures.LanguageFeature2008
{
   class Entry
   {
      public Entry()
      {
         //new UsingVars();
         //InvokeExtentionMethods();
         //PartialFunctions();
         AnonymousTypes();
      }

      private void PartialFunctions()
      {
         SomeStupidItem item = new SomeStupidItem();
         item.SomeStupidMethod( "Message" );
      }

      private void InvokeExtentionMethods()
      {
         345.Foo();
         564.Foo("Sweet");
         Console.WriteLine(564.ReverseDigits());
         312465123.DisplayDefiningAssembly();
      }

      private void AnonymousTypes()
      {
         var something = new { Item01 = "34", Item02 = 34 };
         RelflectOverAnonymousTypes(something);
      }

      private void RelflectOverAnonymousTypes( object obj )
      {
         Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
         Console.WriteLine("Base class of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);
         Console.WriteLine("obj.ToString() = {0}", obj.ToString());
         Console.WriteLine( "obj.GetHashCode() = {0}", obj.GetHashCode() );
         Console.WriteLine();
      }
   }
}
