namespace DelegatesEventsLambdas.DelegatesEventsLambdas.Delegates
{
   public delegate int BinaryOp(int x, int y);
   public delegate double MonoOp(double x);

   public class SimpleMath
   {
      public int Add( int x, int y )
      {
         return x + y;
      }

      public int Subtract( int x, int y )
      {
         return x - y;
      }

      public double Square( double x )
      {
         return x * x;
      }
   }
}
