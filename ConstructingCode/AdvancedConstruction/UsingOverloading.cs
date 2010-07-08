using System;

namespace ConstructingCode.AdvancedConstruction
{
   class UsingOverloading
   {
      public UsingOverloading()
      {
          Console.WriteLine("asdfasdfadsf");
          Calculate(3, 4);
          Calculate(0xFFFFFF, 0xFFFFFF, "");
          Calculate(6.1324123412341234, 5.1253124123561642614146124521);
          Console.ReadLine();
      }

      private void Calculate(int x, int y)
      {
          Console.WriteLine("Using INT");
          Console.WriteLine(x * y);
      }

      private void Calculate(uint x, uint y, string force)
      {
          Console.WriteLine("Using uint");
          Console.WriteLine(x * y);
      }

      private void Calculate(double x, double y)
      {
          Console.WriteLine("Using DOUBLE");
          Console.WriteLine(x * y);
      }
   }
}
