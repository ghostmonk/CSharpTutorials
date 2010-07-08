using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Comparable
{
   class StoreItem : IComparable
   {
      public StoreItem( string name, double price )
      {
         Name = name;
         Price = price;
      }

      public double Price
      {
         get; set;
      }

      public string Name
      {
         get; set;
      }

      public static IComparer NameComparer
      {
         get { return (IComparer) new StoreItemComparer(); }
      }

      public int CompareTo( object obj )
      {
         StoreItem temp = (StoreItem) obj;
         if (Price > temp.Price)
            return 1;
         if (Price < temp.Price)
            return -1;
         else
            return 0;
      }
   }
}
