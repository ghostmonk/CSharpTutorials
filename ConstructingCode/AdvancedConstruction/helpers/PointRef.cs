using System;

namespace ConstructingCode.AdvancedConstruction.helpers
{
   class PointRef : IPoint
   {
      public PointRef( int XPos, int YPos)
      {
         X = XPos;
         Y = YPos;
      }

      public int Y
      {
         get; set;
      }

      public int X
      {
         get; set;
      }

      public void Increment()
      {
         X++;
         Y++;
      }

      public void Decrement()
      {
         Y--;
         X--;
      }

      public void Display()
      {
         Console.WriteLine( "X: " + X + " Y: " + Y );
      }
   }
}
