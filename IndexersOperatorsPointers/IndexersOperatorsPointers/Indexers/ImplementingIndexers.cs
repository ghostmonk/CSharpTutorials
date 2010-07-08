using System;
using System.Collections.Generic;

namespace IndexersOperatorsPointers.IndexersOperatorsPointers.Indexers
{
   class ImplementingIndexers
   {
      public ImplementingIndexers()
      {
         RunArsenal();
      }

      private void RunArsenal()
      {
         Arsenal arsenal = new Arsenal();
         arsenal["bomb"] = new Weapon(WeaponCategory.Explosive, 300) {Name = "IED", Power = 45};
         arsenal["m16"] = new Weapon(WeaponCategory.Shoot, 100) {Name = "M16", Power = 55};
         arsenal["sword"] = new Weapon(WeaponCategory.Slice, 8000) {Name = "Katana", Power = 95};
         arsenal["bomb"] = new Weapon( WeaponCategory.Specialized, 900 ) { Name = "NuclearMissle", Power = 100 };

         foreach( KeyValuePair<string, Weapon> item in arsenal )
         {
            Console.WriteLine( item.Key );
            item.Value.Display();
         }
            
      }
   }
}
