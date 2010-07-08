using System;
using DelegatesEventsLambdas.DelegatesEventsLambdas.Delegates;
using DelegatesEventsLambdas.DelegatesEventsLambdas.ElaborateDelegate;
using DelegatesEventsLambdas.DelegatesEventsLambdas.Events;

namespace DelegatesEventsLambdas.DelegatesEventsLambdas
{
   class DelegationAndSuch
   {
      private NuclearReactor reactor;

      public DelegationAndSuch()
      {
         //SimpleDelegate();
         //RunNuclearReactor();
         //RunRPGAdventure();
         //RunGenericDelegate();
         int bing = 0;
         int bong = 0;
         int bang;
         SimpleResponderProgram( ref bing, bong, out bang );
         Console.WriteLine( bing );
         Console.WriteLine( bong );
         Console.WriteLine( bang );
      }

      private void SimpleResponderProgram( ref int bing, int bong, out int bang )
      {
         bing = 3;
         bang = 4;
         SimpleResponder responder = new SimpleResponder();
         
         responder.AgeInputEvent += OnAgeInputEvent;
         responder.NameInputEvent += OnNameInputEvent;

         responder.AgeInputEvent += (sender, msg) =>
            Console.WriteLine("Handling AgeInputEvent from {1} in anonymous f: Message = {0}", msg, sender);

         responder.NameInputEvent += (sender, msg) =>
            Console.WriteLine("Handling NameInputEvent from {1} in anonymous f: Message = {0}", msg, sender);

         responder.AgeInputEvent += delegate
         {
            bong++;
            Console.WriteLine( "no real args. bong = {0}", bong );
         };

         responder.NameInputEvent += delegate
         {
            bong++;
            Console.WriteLine( "no real args. bong = {0}", bong );
         };
         
         responder.init();
      }

      void OnNameInputEvent(object sender, MessageEventArgs e)
      {
         Console.WriteLine( "Successfully caught Name Input Event from {1}: Message = {0}", e.Msg, sender );
      }

      private void OnAgeInputEvent(object sender, MessageEventArgs e)
      {
         Console.WriteLine( "Successfully caught Age Input Event from {1}: Message = {0}", e.Msg, sender );
      }

      private void RunGenericDelegate()
      {
         GenericDelegate.MyGenericDelegate<string> alert = GenericDelegate.OutputMsg;
         alert("Eat a little of this.");
         GenericDelegate.MyGenericDelegate<int> alertSquare = GenericDelegate.OutputSquare;
         alertSquare(234);
      }

      //Call my item processor in the AdventureParty object, passing a delegate
      //There are two way to pass the delegate... explicitly by creating the delegate,
      //passing a method with the proper signature to this delegate, and then sending the delegate 
      //to the item processor, or more simply, sending the method with the proper signature to 
      //the item processor with will behind the scenes do this work for you.
      //When the process is invoked in the item processor, the methods will be executed with the 
      //appropriate parameters/arguments.
      private void RunRPGAdventure()
      {
         AdventureParty party = new AdventureParty();
         FightManager fightManager = new FightManager();
         
         FightManager.SpawnPartyMember characterFactory = fightManager.GetNewPartyMember;
         FightManager.SpawnPartyMember dwarfFactory = fightManager.CreateDwarf;

         party.AddMember( dwarfFactory( "Riah" ) );
         party.AddMember( characterFactory( "Billrhiem" ) );
         party.AddMember( characterFactory( "Fark" ) );
         party.AddMember( characterFactory( "Storak" ) );
         party.AddMember( characterFactory( "Werkiel" ) );

         party.ProcessCharacters(fightManager.SendToBattle);
         party.GetCharacter( "Riah" ).IsDead = true;
         party.GetCharacter( "Fark" ).IsDead = true;
         party.ProcessCharacters(fightManager.CheckHealth);
      }

      private void RunNuclearReactor()
      {
         reactor = new NuclearReactor(NuclearReactorType.Large);
         reactor.Observer.AddReactorOverHeating( ReactorOverHeating );
         reactor.Observer.AddReactorOverHeating( SendAnEmail );
         reactor.Observer.AddReactorMeltDown( NuclearMeltDown );
         reactor.Display();
         reactor.StartReactor();
         reactor.RaiseControlRod( 1000000 );
         reactor.RaiseControlRod( 1000000 );
         reactor.RaiseControlRod( 200000 );
      }

      private void SendAnEmail( string msg )
      {
         Console.WriteLine( "Send an email, shit is going down." );
      }

      private void ReactorOverHeating(string msg)
      {
         reactor.Observer.RemoveReactorOverHeating( ReactorOverHeating );
         Console.WriteLine(msg);
      }

      private void NuclearMeltDown(string msg)
      {
         Console.WriteLine( msg );
      }

      private void SimpleDelegate()
      {
         SimpleMath calc = new SimpleMath();
         BinaryOp add = calc.Add;
         BinaryOp sub = calc.Subtract;
         MonoOp sqr = calc.Square;
         Console.WriteLine( add( 10, 10 ) );
         Console.WriteLine( sub( 10, 5 ) );
         Console.WriteLine( sqr(3) );

         ReadDelegate(add);
         ReadDelegate(sub);
         ReadDelegate(sqr);
      }

      private void ReadDelegate( Delegate delObj )
      {
         foreach (Delegate del in delObj.GetInvocationList())
         {
            Console.WriteLine("Method {0}", del.Method);
            Console.WriteLine("Target {0}", del.Target);
         }
      }
   }
}
