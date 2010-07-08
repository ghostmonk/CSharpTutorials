using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesEventsLambdas.DelegatesEventsLambdas.ElaborateDelegate
{
   class GenericDelegate
   {
      public delegate void MyGenericDelegate<T>(T arg);

      public static void OutputMsg( string arg )
      {
         Console.WriteLine( arg );
      }

      public static void OutputSquare(int value)
      {
         Console.WriteLine( value * value );
      }
   }
}
