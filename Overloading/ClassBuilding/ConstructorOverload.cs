using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overloading.ClassBuilding
{
   class ConstructorOverload
   {
      private static ConstructorOverload oneParam = new ConstructorOverload( "Jennifer" );
      private static ConstructorOverload allParams = new ConstructorOverload( "Lucas", 5000 );

      public ConstructorOverload()
         : this( "billy", 1000 ) {}

      public ConstructorOverload( string name )
         : this( name, 2000 ) {}

      public ConstructorOverload( string name, int id )
      {
         Name = name;
         ID = id;
         Console.WriteLine( "Name: " + name + " ID: " + ID );
      }

      public int ID
      {
         get; set;
      }

      public string Name
      {
         get; set;
      }
   }
}
