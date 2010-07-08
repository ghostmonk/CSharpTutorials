using System;

namespace ConstructingCode.BasicConstruction
{
   class TypeConversions
   {
      public TypeConversions()
      {
         Widening();
         NarrowinAttempt();
         ProcessBytes();
      }

      private void Widening()
      {
         short numb1 = 30000, numb2 = 30000;
         short answer = (short) Add(numb1, numb2);
         Console.WriteLine(answer);
      }

      private void ProcessBytes()
      {
         byte b1 = 100;
         byte b2 = 250;
         try
         {
            checked
            {
               byte sum = (byte)Add(b1, b2);
               Console.WriteLine(sum);
            }
         }
         catch (OverflowException ex)
         {
            Console.WriteLine(ex.Message);
         }

         unchecked
         {
            byte sum = (byte)Add(b1, b2);
            Console.WriteLine(sum);
         }
      }

      private void NarrowinAttempt()
      {
         byte myByte = 0;
         int myInt = 200;
         myByte = (byte) myInt;
         Console.WriteLine(myByte);
      }

      private int Add(int x, int y)
      {
         return x + y;
      }
   }
}
