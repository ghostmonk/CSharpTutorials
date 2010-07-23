using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqDataBaseAccess.Basics;
using LinqDataBaseAccess.GeneratedFiles;
using LinqDataBaseAccess.LinqMapping;

namespace LinqDataBaseAccess
{
   class Program
   {
      static void Main(string[] args)
      {
         //new LinqOverDataSet();
         //new LinqToSql();
         new LinqGen();
         Console.ReadLine();
      }
   }
}