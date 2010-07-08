using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangFeatures.LanguageFeature2008.partialMethods
{
   partial class SomeStupidItem
   {
      public bool SomeStupidMethod( string someStupidId )
      {
         VerifyThisStupidId( someStupidId );
         return true;
      }

      partial void VerifyThisStupidId(string msg);
   }
}
