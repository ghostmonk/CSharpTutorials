using System;
using Overloading.ClassBuilding;

namespace Overloading
{
   class Program
   {
      static void Main(string[] args)
      {
         new PassByValRefOverload();
         new ConstructorOverload();
         Console.ReadLine();
      }
   }
}