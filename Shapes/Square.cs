using System;

namespace Shapes
{
   public class Square : BaseShape
   {
      public Square()
      {
         Sides = 4;
      }

      public override void Draw()
      {
         Console.WriteLine( "Draw Square {0} sides: Version 2", 4 );
      }
   }
}
