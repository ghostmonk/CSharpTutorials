using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Comparable
{
   class GeneralStore
   {
      ArrayList Items = new ArrayList();

      public GeneralStore()
      {
         Items.Add( new StoreItem( "apple", 0.50 ) );
         Items.Add( new StoreItem( "pear", 0.30 ) );
         Items.Add( new StoreItem( "peach", 0.85 ) );
         Items.Add( new StoreItem( "javex", 2.40 ) );
         Items.Add( new StoreItem( "yop", 1.20 ) );
         Items.Add( new StoreItem( "cabbage", 3.66 ) );
         Items.Add( new StoreItem( "whole wheat bread", 4.00 ) );
         Items.Add( new StoreItem( "salt", 5.40 ) );
         ReadList( Items );
         Items.Sort();
         ReadList( Items );
         Items.Sort(StoreItem.NameComparer);
         ReadList( Items );
      }

      private void ReadList( ArrayList list )
      {
         foreach( StoreItem item in list )
            Console.WriteLine( "{0}, {1}", item.Name, item.Price );
         Console.WriteLine();
      }
   }
}
