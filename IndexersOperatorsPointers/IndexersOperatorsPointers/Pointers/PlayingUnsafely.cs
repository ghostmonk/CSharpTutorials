using System;
using IndexersOperatorsPointers.IndexersOperatorsPointers.Operators;

namespace IndexersOperatorsPointers.IndexersOperatorsPointers.Pointers
{
   class PlayingUnsafely
   {
      public PlayingUnsafely()
      {
         SimpleTest();
         
         Console.WriteLine();
         MixingPointersWithManaged();

         Console.WriteLine();
         ValueSwapping();

         Console.WriteLine();
         UsePointerToPointer();

         Console.WriteLine();
         UnsafeStackAlloc();

         Console.WriteLine();
         UseAndPinPoint();

         Console.WriteLine();
         UseSizeOfOperator();
      }

      unsafe void UseSizeOfOperator()
      {
         Console.WriteLine( "Size of short is {0}", sizeof( short ) );
         Console.WriteLine( "Size of int is {0}", sizeof( int ) );
         Console.WriteLine( "Size of long is {0}", sizeof( long ) );
         Console.WriteLine( "Size of point is {0}", sizeof( Point ) );
      }

      unsafe void UseAndPinPoint()
      {
         PointRef pt = new PointRef{x=5, y=6};

         fixed (int* p = &pt.x)
            Console.WriteLine("Pinned Value: {0}", *p);

         Console.WriteLine("Point is: {0}", pt);

      }

      unsafe void UnsafeStackAlloc()
      {
         char* p = stackalloc char[256];
         for (int k = 0; k < 256; k++)
         {
            p[k] = (char) k;
            Console.Write( " {0}", p[k] );
         }
         Console.WriteLine();
      }

      private void ValueSwapping()
      {
         int i = 10;
         int j = 22;
         Console.WriteLine("Safe Swap on i = {0}, j = {1}", i, j);
         SafeSwap(ref i, ref j);
         Console.WriteLine("Result: i = {0}, j = {1}", i, j);

         Console.WriteLine("Unsafe Swap on i = {0}, j = {1}", i, j);
         unsafe { UnsafeSwap(&i, &j); }
         Console.WriteLine("Result: i = {0}, j = {1}", i, j);
      }

      unsafe private void UsePointerToPointer()
      {
         Point point;
         Point* p = &point;
         p->X = 100;
         p->Y = 200;
         Console.WriteLine(p->ToString());

         Point point2;
         Point* p2 = &point2;
         (*p2).X = 100;
         (*p2).Y = 300;
         Console.WriteLine((*p2).ToString());
      }

      unsafe private void MixingPointersWithManaged()
      {
         int simpleValue;
         int* pointerValue = &simpleValue;

         *pointerValue = 345;

         Console.WriteLine("SimpleValue = {0}", simpleValue);
         Console.WriteLine("Pointerized Value = {0}", (int)&pointerValue);
         Console.WriteLine( "Pointerized *Value = {0}", *pointerValue );
      }

      unsafe private void SimpleTest()
      {
         int testingNumber = 10;
         SquareIntPointer( &testingNumber );
         Console.WriteLine( "Int Pointer = {0}", testingNumber );
      }

      unsafe static void SquareIntPointer( int* intPointer )
      {
         *intPointer *= *intPointer;
      }

      unsafe public static void UnsafeSwap(int* i, int* j)
      {
         int temp = *i;
         *i = *j;
         *j = temp;
      }

      public static void SafeSwap( ref int i, ref int j )
      {
         int temp = i;
         i = j;
         j = temp;
      }
   }

   public struct Node
   {
      public int Value;
      public unsafe Node* Left;
      public unsafe Node* Right;
   }

   public unsafe struct DangerNode
   {
      public int Value;
      public Node* Left;
      public Node* Right;
   }
}
