using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexersOperatorsPointers.IndexersOperatorsPointers.Operators
{
   public struct Point : IComparable<Point>
   {
      public Point(int x, int y) : this()
      {
         X = x;
         Y = y;
      }

      public int X
      {
         get; set;
      }

      public int Y
      {
         get; set;
      }

      public override int GetHashCode()
      {
         return ToString().GetHashCode();
      }

      public override bool Equals(object obj)
      {
         return obj.ToString() == ToString();
      }

      public static bool operator == (Point p1, Point p2)
      {
         return p1.Equals(p2);
      }

      public static bool operator != (Point p1, Point p2)
      {
         return !p1.Equals( p2 );
      }

      public static Point operator ++ (Point p)
      {
         return new Point( p.X + 1, p.Y + 1 );
      }

      public static Point operator -- (Point p)
      {
         return new Point( p.X - 1, p.Y - 1 );
      }

      public static Point operator + (Point p1, Point p2)
      {
         return new Point( p1.X + p2.X, p1.Y + p2.Y );
      }

      public static Point operator - (Point p1, Point p2)
      {
         return new Point( p1.X - p2.X, p1.Y - p2.Y );
      }

      public static bool operator < (Point p1, Point p2)
      {
         return p1.CompareTo(p2) < 0;
      }

      public static bool operator > (Point p1, Point p2)
      {
         return p1.CompareTo(p2) > 0;
      }

      public static bool operator >= (Point p1, Point p2)
      {
         return p1.CompareTo(p2) >= 0;
      }

      public static bool operator <= (Point p1, Point p2)
      {
         return p1.CompareTo( p2 ) <= 0;
      }

      public int CompareTo(Point other)
      {
         if ( X > other.X && Y > other.Y )
            return 1;
         if ( X < other.X && Y < other.Y )
            return -1;
         
         return 0;
      }

      public override string ToString()
      {
         return string.Format("{0}, {1}", X, Y);
      }
   }
}
