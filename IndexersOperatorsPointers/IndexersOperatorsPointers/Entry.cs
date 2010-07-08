using System;
using IndexersOperatorsPointers.IndexersOperatorsPointers.CustomConversions;
using IndexersOperatorsPointers.IndexersOperatorsPointers.Pointers;

namespace IndexersOperatorsPointers.IndexersOperatorsPointers
{
   class Entry
   {
      public Entry()
      {
         //new ImplementingIndexers();
         //new OperatorOverride();
         //SecondComming();
         new PlayingUnsafely();
      }

      private void SecondComming()
      {
         Jesus christ = new Jesus();
         Wine wine = new Wine(WineType.bordeaux) {NumberOfLiters = 22, TempInCelcius = 22};
         Water water = new Water(WaterType.sewer) {NumberOfLiters = 20, TempInCelcius = 14};
         christ.WaterToWine(water);
         Console.WriteLine();
         christ.WineToWater( wine );
         Console.WriteLine();

         Water someWater = 3;
         Water someMoreWater = WaterType.salt;

         Console.WriteLine(someWater);
         Console.WriteLine(someMoreWater);
      }
   }
}
