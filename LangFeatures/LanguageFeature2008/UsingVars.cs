using System;
using System.Linq;
using System.Collections.Generic;

namespace LangFeatures.LanguageFeature2008
{
   class UsingVars
   {
      public UsingVars()
      {
         QueryOverInts();
      }

      public void QueryOverInts()
      {
         int[] numbers = {10,20,30,40,1,2,3,8};
         IEnumerable<int> subset = from i in numbers where i < 10 select i;
         
         foreach (int i in subset)
            Console.Write("{0} ", i);
      }
   }
}
