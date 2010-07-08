using System;

namespace PolymorpAndParitals.Classes 
{
   /// <summary>
   /// This is the class level documentation for a Derivative class.
   /// </summary>
   sealed class AccessMutDerivative : AccessorsMutators
   {
      /// <summary>
      /// I'm guessing you can't document private variables.
      /// </summary>
      private string overrideVar = "Derivative override";
      
      /// <summary>
      /// This is an immutable const
      /// </summary>
      public const string SOME_CONST = "I cannot be changed";

      /// <summary>
      /// This is a derivative to test behaviour of encapsulation
      /// and inheritance.
      /// </summary>
      public AccessMutDerivative()
      {
         ProtectedSetter = overrideVar;
      }

      /// <summary>
      /// What happens when you document an overriden protected function that is
      /// also documented.
      /// </summary>
      protected override void DoSomeInterestingStuff()
      {
         Console.WriteLine( "I'm doing some interesting derivative stuff." );
      }

      /// <summary>
      /// What happens when I document a private function.
      /// </summary>
      private void IDoNothing(){}
   }
}
