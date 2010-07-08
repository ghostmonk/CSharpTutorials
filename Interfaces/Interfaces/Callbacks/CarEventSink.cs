using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExceptionsErrors.Errors;

namespace Interfaces.Interfaces.Callbacks
{
   class CarEventSink : IEngineNotification 
   {
      private string _name;

      public CarEventSink(string name)
      {
         _name = name;   
      }

      public void AboutToBlow(string msg)
      {
         Console.WriteLine("{0} Reporting: {1}", _name, msg);
      }

      public void Exploded(string msg)
      {
         Console.WriteLine( "{0} Reporting Explosion: {1}", _name, msg );
      }
   }
}
