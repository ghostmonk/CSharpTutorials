using System;

namespace DelegatesEventsLambdas.DelegatesEventsLambdas.Events
{
   class SimpleResponder 
   {
      public event EventHandler<MessageEventArgs> NameInputEvent;
      public event EventHandler<MessageEventArgs> AgeInputEvent;

      public void init()
      {
         Console.WriteLine( "What is your name?" );
         Dispatch( NameInputEvent, Console.ReadLine() );
         Console.WriteLine( "What is your Age?" );
         Dispatch( AgeInputEvent, Console.ReadLine() );
      }

      private void Dispatch( EventHandler<MessageEventArgs> handler, string msg )
      {
         if( handler != null )
            handler(this, new MessageEventArgs(msg));
      }
   }
}
