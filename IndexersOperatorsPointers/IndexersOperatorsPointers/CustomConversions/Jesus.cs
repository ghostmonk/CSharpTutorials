using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexersOperatorsPointers.IndexersOperatorsPointers.CustomConversions
{
   class Jesus
   {
      public void WaterToWine( Water liquid )
      {
         Wine wine = liquid;
         Console.Write("Performing Miracle on: ");
         Console.WriteLine( liquid );
         Console.Write( "Liquid is now: " );
         Console.WriteLine( wine );
      }

      public void WineToWater( Wine liquid )
      {
         Water water = liquid;
         Console.Write( "Performing Miracle on: " );
         Console.WriteLine( liquid );
         Console.Write( "Liquid is now: " );
         Console.WriteLine( water );
      }
   }
}
