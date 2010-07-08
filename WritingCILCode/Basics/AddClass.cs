using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WritingCILCode.Basics
{
   class AddClass
   {
      public static int Add(int x, int y)
      {
         return x + y;
      }

      public void PrintMessage()
      {
         string myMessage = "Hello!";
         Console.WriteLine(myMessage);
      }
   }
}
