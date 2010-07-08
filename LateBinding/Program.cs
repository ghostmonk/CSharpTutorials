using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LateBinding.SmallExamples;

namespace LateBinding
{
   class Program
   {
      static void Main(string[] args)
      {
         /*new CreateDynamicType();
         new UsingSerializable();
         new GetAttributesEarlyBinding();*/
         new GetAttributesLateBinding();
         Console.ReadLine();
      }
   }
}
