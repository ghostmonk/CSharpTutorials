using System;

namespace Shapes
{
   public class Hexigon : BaseShape
   {
      public Hexigon()
      {
         Sides = 6;
      }

      public override void Draw()
      {
         Console.WriteLine("Draw Hexigon with {0} sides: Version 2", Sides);
      }
   }
}
