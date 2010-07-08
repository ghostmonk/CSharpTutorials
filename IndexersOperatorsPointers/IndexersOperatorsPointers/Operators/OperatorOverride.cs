using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexersOperatorsPointers.IndexersOperatorsPointers.Operators
{
   class OperatorOverride
   {
      public OperatorOverride()
      {
         //PlusAndMinus();
         //Unary();
         //Equality();
         Comparison();
      }

      public void PlusAndMinus()
      {
         Point point1 = new Point(30, 30);
         point1 += new Point(20,20);

         Point point2 = new Point(10,10);
         point2 -= new Point(5,5);
         
         Console.WriteLine(point1 + point2);
         Console.WriteLine( point1 - point2 );
      }

      public void Unary()
      {
         Point point = new Point(1,1);
         Console.WriteLine( ++point );
         Console.WriteLine( --point );
         Console.WriteLine( point++ );
         Console.WriteLine( point-- ); 
      }

      public void Equality()
      {
         Point point1 = new Point( 2, 2 );
         Point point2 = new Point( 2, 2 );
         Point point3 = new Point( 3, 3 );
         Console.WriteLine(point1 == point2);
         Console.WriteLine(point1 != point2);
         Console.WriteLine(point2 == point3);
         Console.WriteLine(point2 != point3);
      }

      public void Comparison()
      {
         Point point1 = new Point( 2, 2 );
         Point point2 = new Point( 2, 2 );
         Point point3 = new Point( 3, 3 );
         Console.WriteLine(point1 <= point2);
         Console.WriteLine(point1 >= point2);
         Console.WriteLine(point1 <= point3);
         Console.WriteLine(point1 >= point3);
         Console.WriteLine(point3 <= point1);
         Console.WriteLine(point3 >= point1);
      }
   }
}
