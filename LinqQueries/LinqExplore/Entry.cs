using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqQueries.LinqExplore
{
   class Entry
   {
      public Entry()
      {
        /* QueryOverStrings();
         Console.WriteLine();
         QueryOverInts();
         Console.WriteLine();
         DifferedExecution();*/
         new LinqGenerics();
      }

      private void QueryOverStrings()
      {
         string[] videoGames = {"Morrowind", "BioShock", "HalfLife 2", "The Darkness", "Daxter", "System Shock"};
         IEnumerable<string> subset = from g in videoGames where g.Length > 6 orderby g select g;
         
         foreach (string s in subset)
            Console.WriteLine("Item: {0}", s);
         ReflectOverQueryResults(subset);
      }

      private void QueryOverInts()
      {
         int[] numbers = {10, 20, 30, 40, 50, 6, 2, 6, 8, 9};
         var subset = from i in numbers where i < 10 select i;

         foreach (int i in subset)
            Console.WriteLine("Item: {0}", i);
         ReflectOverQueryResults(subset);
      }

      private void DifferedExecution()
      {
         int[] numbers = {2, 3, 4, 5, 7, 8, 29, 390, 341, 1234, 6153, 782};

         IEnumerable<int> subset = from i in numbers where i < 10 select i;

         foreach (int i in subset)
            Console.WriteLine(i);
         Console.WriteLine();

         numbers[0] = 5;

         foreach (int i in subset)
            Console.WriteLine( i );
         Console.WriteLine();
      }

      private void ReflectOverQueryResults( object resultSet )
      {
         Console.WriteLine("result in of type: {0}", resultSet.GetType().Name);
         Console.WriteLine("result location: {0}", resultSet.GetType().Assembly);
      }
   }
}
