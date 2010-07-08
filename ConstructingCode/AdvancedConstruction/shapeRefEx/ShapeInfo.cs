using System;

namespace ConstructingCode.AdvancedConstruction.shapeRefEx
{
   class ShapeInfo
   {
      public ShapeInfo( string info)
      {
         Info = info;
      }

      public string Info
      {
         get; set;
      }
   }

   struct Rectangle
   {
      public Rectangle( string info, int top, int bottom, int left, int right ) 
         : this()
      {
         Info = new ShapeInfo(info);
         Top = top;
         Bottom = bottom;
         Left = left;
         Right = right;
      }

      public ShapeInfo Info
      {
         get; set;
      }

      public int Top
      {
         get; set;
      }

      public int Left
      {
         get; set;
      }

      public int Right
      {
         get; set;
      }

      public int Bottom
      {
         get; set;
      }

      public void Display()
      {
         Console.Write ("Info: " + Info.Info);
         Console.Write( " Top:" + Top );
         Console.Write( " Bottom:" + Bottom );
         Console.Write( " Left:" + Left );
         Console.Write( " Right:" + Right );
         Console.WriteLine();
      }
   }
}
