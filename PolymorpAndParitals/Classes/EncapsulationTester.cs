using System;

namespace PolymorpAndParitals.Classes
{
   /// <summary>
   /// This is the base class I use for testing some of this languages
   /// implementation of common OOP concepts
   /// </summary>
   sealed class EncapsulationTester
   {
      /// <summary>
      /// Everything is run and set up from this constructor.
      /// </summary>
      public EncapsulationTester()
      {
         AccessorsMutators BaseClass = new AccessorsMutators();
         AccessMutDerivative DerivedClass = new AccessMutDerivative();
         
         Console.WriteLine( BaseClass.ProtectedSetter );
         Console.WriteLine( DerivedClass.ProtectedSetter );

         Console.WriteLine();
         
         BaseClass.Display();
         DerivedClass.Display();

         Console.WriteLine();

         BaseClass.SetOnlyInfo = "BaseClass set only";
         DerivedClass.SetOnlyInfo = "Derived set only";

         Console.WriteLine();

         Console.WriteLine( BaseClass.ReadOnlyInfo );
         Console.WriteLine( DerivedClass.ReadOnlyInfo );

         Console.WriteLine();

         Console.WriteLine( AccessorsMutators.StaticInfo );

         Console.WriteLine();

         Console.WriteLine(AccessMutDerivative.SOME_CONST);
      }
   }
}
