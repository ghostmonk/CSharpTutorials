using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesEventsLambdas.DelegatesEventsLambdas.Events
{
   class MessageEventArgs : EventArgs
   {
      private readonly string msg;

      public MessageEventArgs( string msg )
      {
         this.msg = msg;
      }

      public string Msg
      {
         get { return msg; }
      }
   }
}
