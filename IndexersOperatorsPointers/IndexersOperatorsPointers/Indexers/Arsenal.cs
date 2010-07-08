using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexersOperatorsPointers.IndexersOperatorsPointers.Indexers
{
   class Arsenal : IEnumerable<KeyValuePair <string, Weapon>>
   {
      private readonly Dictionary<string, Weapon> weapons = new Dictionary<string, Weapon>();

      public Weapon this[string index]
      {
         get { return weapons[index]; }
         set { weapons[index] = value; }
      }

      public void Clear()
      {
         weapons.Clear();
      }

      public int Count
      {
         get { return weapons.Count; }
      }

      public IEnumerator<KeyValuePair<string, Weapon>> GetEnumerator()
      {
         return weapons.GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}
