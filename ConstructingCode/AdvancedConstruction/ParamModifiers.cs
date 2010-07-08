using System;

namespace ConstructingCode.AdvancedConstruction
{
   class ParamModifiers
   {
      public ParamModifiers()
      {
         int ans;
         Add( 100, 80, out ans );
         Console.WriteLine( ans );

         int a, b, c;
         MultipleReturns( out a, out b, out c );
         Console.WriteLine( a + " " + b + " " + c );

         string s1 = "Flip";
         string s2 = "Flop";
         Console.WriteLine( s1 + " " + s2 );
         UsingRefKeyword( ref s1, ref s2 );
         Console.WriteLine( s1 + " " + s2 );

         Console.WriteLine( UsingParamsKeyword( 1, 2, 3, 4, 5 ) );
         Console.WriteLine( UsingParamsKeyword( new double[] {1, 2, 3, 4, 5 } ) );

      }

      private void Add(int x, int y, out int ans)
      {
         ans = x + y;
      }

      private void MultipleReturns(out int a, out int b, out int c)
      {
         a = 67;
         b = 78;
         c = 98;
      }

      private void UsingRefKeyword(ref string s1, ref string s2)
      {
         string temp = s1;
         s1 = s2;
         s2 = temp;
      }

      private double UsingParamsKeyword(params double[] values)
      {
         double sum = 0;

         for (int i = 0; i < values.Length; i++)
            sum += values[i];

         return sum / values.Length;
      }
   }
}
