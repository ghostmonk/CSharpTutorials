using System;

namespace ConstructingCode.AdvancedConstruction
{
   class ArrayManip
   {
      public ArrayManip()
      {
         SimpleArray();
         ArrayInitialization();
         RectMultiDimensionalArrays();
         JaggedMultiDimensionalArrays();
         WorkingWithArrayMethods();
         Console.ReadLine();
      }

      private void SimpleArray()
      {
         int[] myInts = new int[3];
         myInts[0] = 1;
         myInts[1] = 2;
         myInts[2] = 3;

         string[] myBooks = new string[100];

         PrintArray( "This int was found ", myInts, false );
         PrintArray( "This book was found", myBooks, false );
      }

      private void ArrayInitialization()
      {
         string[] stringCollection = new[] { "one", "two", "three" };
         PrintArray( "String Array Value:", stringCollection, false );
         PrintArray( "Boolean Array:", new[] { true, false, true }, false );
      }

      private void RectMultiDimensionalArrays()
      {
         int[,] matrix;
         matrix = new int[6, 6];

         for (int i = 0; i < 6; i++)
            for (int j = 0; j < 6; j++)
               matrix[i, j] = i * j;

         for (int i = 0; i < 6; i++)
         {
            for (int j = 0; j < 6; j++)
               Console.Write( matrix[i, j] + "\t" );
            Console.WriteLine();
         }
      }

      private void JaggedMultiDimensionalArrays()
      {
         int[][] jaggedArray = new int[5][];

         for (int i = 0; i < jaggedArray.Length; i++)
            jaggedArray[i] = new int[i + 7];

         for (int i = 0; i < 5; i++)
         {
            for (int j = 0; j < jaggedArray[i].Length; j++)
               Console.Write( jaggedArray[i][j] + " " );
            Console.WriteLine();
         }
         Console.WriteLine();
      }

      private void WorkingWithArrayMethods()
      {
         string[] bands = { "The Band", "Broken Belles", "Muford and Sons", "Edward Sharpe" };
         PrintArray( "", bands, true );
         Array.Reverse(bands);
         PrintArray( "", bands, true);
         Array.Clear(bands, 1, 2);
         PrintArray( "", bands, true );
      }

      private void PrintArray(string pref, Array list, bool sameLine)
      {
         foreach (object item in list)
            if (item != null)
               if (sameLine)
                  Console.Write( pref + " " + item.ToString() );
               else
                  Console.WriteLine( pref + " " + item.ToString() );
         Console.WriteLine();
      }
   }
}
