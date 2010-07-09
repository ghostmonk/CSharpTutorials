using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectSerialization.CarExample;
using ObjectSerialization.Utils;

namespace ObjectSerialization
{
   class Program
   {
      static void Main(string[] args)
      {
         //new UsingSerializable();
         new CarSerializer();
         Console.ReadLine();
      }
   }
}
