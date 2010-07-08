using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overloading.ClassBuilding
{
   class PassByValRefOverload
   {
      public PassByValRefOverload()
      {
         string name = "Paul";
         Console.WriteLine( name );
         string peter = fixMe(name);
         Console.WriteLine( peter );
         fixMe(name);
         Console.WriteLine( name );
         fixMe(ref name);
         Console.WriteLine( name );
      }

      private void fixMe(ref string name)
      {
         name = "Mark";
      }

      private string fixMe(string name)
      {
         name = "Peter";
         return name;
      }

      private void test()
      {
         test( "asdfasdf" );
      }

      private void test( string val )
      {
         
      }
   }

}
