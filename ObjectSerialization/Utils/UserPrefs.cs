using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectSerialization.Utils
{
   [Serializable]
   class UserPrefs
   {
      public string WindowColor
      {
         get; set;
      }

      public int FontSize
      {
         get; set;
      }
   }
}
