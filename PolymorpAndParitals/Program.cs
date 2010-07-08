using System;
using PolymorpAndParitals.Classes;
using PolymorpAndParitals.PolyMorphism;

namespace PolymorpAndParitals
{
   /// <summary>
   /// Is there any point in documenting the Program class.
   /// </summary>
   class Program
   {
      /// <summary>
      /// Well obviously this is where the program is bootstrapped.
      /// But is there a good reason to document it? Maybe if you have 
      /// multiple entry points.
      /// </summary>
      /// <param name="args">This is your classic argument for startig up a program in C#.</param>
      static void Main(string[] args)
      {
         //new EncapsulationTester();
         //new Business();
         new ObjectType();
         Console.ReadLine();
      }
   }
}
