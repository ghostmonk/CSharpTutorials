namespace DelegatesEventsLambdas.DelegatesEventsLambdas.Delegates
{
   class ReactorObserver
   {
      public delegate void ImminentDanger(string msg);
      public delegate void NuclearMeltDown(string msg);

      private ImminentDanger imminentDangerList;
      private NuclearMeltDown nuclearMeltDownList;

      public void AddReactorOverHeating(ImminentDanger clientMethod)
      {
         imminentDangerList += clientMethod;
      }

      public void RemoveReactorOverHeating(ImminentDanger clientMethod)
      {
         imminentDangerList -= clientMethod;
      }

      public void AddReactorMeltDown(NuclearMeltDown clientMethod)
      {
         nuclearMeltDownList += clientMethod;
      }

      public void OnImminentDanger( string msg )
      {
         if( imminentDangerList != null )
            imminentDangerList.Invoke( msg );
      }

      public void OnMeltDown( string msg )
      {
         if ( nuclearMeltDownList != null )
            nuclearMeltDownList.Invoke( msg );
      }
   }
}
