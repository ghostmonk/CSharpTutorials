using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqQueries.LinqExplore
{
   class LinqGenerics
   {
      private ArrayList SomeObjects = new ArrayList(){
         new ObjWithProps{Color = 0x675431, Level = 29, Name = "John", Weight = 195},
         new ObjWithProps{Color = 0x127642, Level = 10, Name = "Amy", Weight = 120},
         new ObjWithProps{Color = 0x23743e, Level = 34, Name = "Billy", Weight = 145},
         new ObjWithProps{Color = 0xa2f542, Level = 8, Name = "Graham", Weight = 150},
         new ObjWithProps{Color = 0xb1c230, Level = 2, Name = "Curtis", Weight = 280}
      };

      private ArrayList SomeOtherObjects = new ArrayList(){
         new ObjWithProps{Color = 0x675431, Level = 29, Name = "John", Weight = 195},
         new ObjWithProps{Color = 0x127642, Level = 10, Name = "Amy", Weight = 120},
         new ObjWithProps{Color = 0x23743e, Level = 34, Name = "Billy", Weight = 145},
         new ObjWithProps{Color = 0xa2f542, Level = 8, Name = "Jules", Weight = 150},
         new ObjWithProps{Color = 0xb1c230, Level = 2, Name = "Prahna", Weight = 280}
      };

      public LinqGenerics()
      {
         FilterTheShitOut();

         IEnumerable<ObjWithProps> objs = SomeObjects.OfType<ObjWithProps>();

         IEnumerable<ObjWithProps> diffs = SomeOtherObjects.OfType<ObjWithProps>();

         Console.WriteLine();
         GetHeavyProps( objs );
         
         Console.WriteLine();
         UsingOrderBy(objs);

         Console.WriteLine();
         UsingLambdas(objs);

         Console.WriteLine();
         UsingAnonymous(objs);

         Console.WriteLine();
         UsingRawDelegates( objs );

         Console.WriteLine();
         CheckCount( objs );

         Console.WriteLine();
         FindDiffs(objs, diffs);
      }

      private void UsingRawDelegates(IEnumerable<ObjWithProps> objs)
      {
         Func<ObjWithProps, bool> searchFilter = Filter;
         Func<ObjWithProps, string> itemToProcess = Process;

         var heavyGuys = objs.Where( searchFilter ).OrderBy( itemToProcess ).Select( itemToProcess );
         Output( heavyGuys, "Raw Delegates!" );
      }

      private bool Filter( ObjWithProps obj)
      {
         return obj.Weight > 140;
      }

      private string Process( ObjWithProps obj )
      {
         return obj.Name;
      }

      private void FindDiffs( IEnumerable<ObjWithProps> src, IEnumerable<ObjWithProps> diff )
      {
         var diffs = (from obj in src select obj.Name).Except(from obj2 in diff select obj2.Name);
         
         Output(diffs,"Differences");
      }

      private void CheckCount(IEnumerable<ObjWithProps> objs)
      {
         int count = (from obj in objs where obj.Weight > 140 orderby obj.Name select obj).Count();
         Console.WriteLine("Count using LINQ {0}", count);
      }

      private void UsingAnonymous(IEnumerable<ObjWithProps> objs)
      {
         Func<ObjWithProps, bool> searchFilter = obj => obj.Weight > 140;
         Func<ObjWithProps, string> itemToProcess = obj => obj.Name;

         var heavyGuys = objs.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);
         Output(heavyGuys,"Anonymous Queries!");
      }

      private void UsingLambdas(IEnumerable<ObjWithProps> objs)
      {
         var heavyGuys = objs.Where( obj => obj.Weight > 140 ).OrderBy( obj => obj.Name ).Select( obj => obj.Name );
         Output( heavyGuys, "Big Query Lambda!" );
      }

      private void UsingOrderBy(IEnumerable<ObjWithProps> objs)
      {
         var heavyGuys = from o in objs where o.Weight > 140 orderby o.Name select o.Name;
         Output( heavyGuys, "Big Query Order!" );
      }

      private void GetHeavyProps(IEnumerable<ObjWithProps> objs)
      {
         var heavyGuys = from o in objs where o.Weight > 140 && o.Level > 5 select o.Name;
         Output(heavyGuys, "is a big Dood!");
      }

      private void Output(IEnumerable<string> names, string msg)
      {
         foreach (var name in names)
            Console.WriteLine("{0} {1}", name, msg);
      }

      private void FilterTheShitOut()
      {
         ArrayList kitchenSink = new ArrayList();
         kitchenSink.AddRange(new object[]{10, 20, "asdfa", true, false, 345.67, new ObjWithProps()});
         IEnumerable<int> filteredInts = kitchenSink.OfType<int>();

         foreach( int i in filteredInts ) 
            Console.WriteLine(i);
      }
   }
}
