using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangFeatures.LanguageFeature2008.partialMethods
{
   partial class SomeStupidItem
   {
      partial void VerifyThisStupidId(string msg)
      {
         Console.WriteLine( "Say something really dumbass here, {0}", msg );  
      }
   }
}
