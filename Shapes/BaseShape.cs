using System;

namespace Shapes
{
   public abstract class BaseShape
   {
      private int sides;

      public int Sides
      {
         get { return sides; }
         protected set { sides = value;  }
      }

      public void WriteColor()
      {
         Console.WriteLine("The Color is Red");
      }

      public enum EggHeads
      {
         Newton, Hawkings, Einstein, Euclid, Galileo, Boer, Edison
      }

      abstract public void Draw();
   }
}