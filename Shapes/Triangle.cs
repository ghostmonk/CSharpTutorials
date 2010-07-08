using System;

namespace Shapes
{
   public class Triangle : BaseShape
   {
      public Triangle()
      {
         Sides = 3;
      }

      public override void Draw()
      {
         Console.WriteLine( "Draw Triangle {0} sides: Version 2", Sides );
      }
   }
}