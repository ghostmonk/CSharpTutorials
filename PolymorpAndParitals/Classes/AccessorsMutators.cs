using System;

namespace PolymorpAndParitals.Classes
{
   /// <summary>
   /// How should I document a class declaration? The results of this
   /// comment should tell me.
   /// </summary>
   class AccessorsMutators
   {
      /// <summary>
      /// I'm guessing you can't document private variables.
      /// </summary>
      private string protSet = "I cannot be set outside of a derivative.";

      /// <summary>
      /// A static readonly property
      /// </summary>
      public static string StaticInfo
      {
         get { return "Static Property Info";  }
      }

      /// <summary>
      /// Your classic property declaraion without any encapulation
      /// </summary>
      public string Info
      {
         get; set;
      }

      /// <summary>
      /// A readonly property
      /// </summary>
      public string ReadOnlyInfo
      {
         get { return "I am a read only var."; }
      }

      /// <summary>
      /// Not much of a reason to have one of these, but as you can see it is possible
      /// </summary>
      public string SetOnlyInfo
      {
         set { Console.WriteLine( value ); }
      }

      /// <summary>
      /// This property is accessible from anywhere, but the 
      /// actual setter can only be invoked from a derivative
      /// </summary>
      public string ProtectedSetter
      {
         get { return protSet; }
         protected set { protSet = value; }
      }

      /// <summary>
      /// This function is overriden in a derivative.
      /// I am interested to see how protected functions are documented.
      /// </summary>
      protected virtual void DoSomeInterestingStuff()
      {
         Console.WriteLine( "I was called from a protected method in the BaseClass." );
      }

      /// <summary>
      /// This will invoke a protected function. It's a test to see the effects 
      /// of overriding the called protected function in the derivative.
      /// </summary>
      public void Display()
      {
         DoSomeInterestingStuff();
      }
   }
}
