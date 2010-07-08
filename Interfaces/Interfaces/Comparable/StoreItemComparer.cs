using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Comparable
{
   class StoreItemComparer : IComparer
   {
      int IComparer.Compare(object x, object y)
      {
         StoreItem item1 = (StoreItem) x;
         StoreItem item2 = (StoreItem) y;
         return String.Compare(item1.Name, item2.Name);
      }
   }
}
