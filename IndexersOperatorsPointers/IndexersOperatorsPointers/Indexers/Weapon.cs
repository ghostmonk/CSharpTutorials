using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexersOperatorsPointers.IndexersOperatorsPointers.Indexers
{
   class Weapon
   {
      private readonly WeaponCategory category;
      private readonly int skillLevel;

      public Weapon(WeaponCategory category, int skillLevel)
      {
         this.skillLevel = skillLevel;
         this.category = category;
      }

      public WeaponCategory Category
      {
         get { return category; }
      }

      public int Power
      {
         get; set;
      }

      public string Name
      {
         get; set;
      }

      public int SkillLevel
      {
         get { return skillLevel;  }
      }

      public void Display()
      {
         Console.WriteLine("Name: {0}", Name);
         Console.WriteLine("Category: {0}", category);
         Console.WriteLine( "SkillLevel:{0}", skillLevel );
         Console.WriteLine("Power: {0}", Power);
         Console.WriteLine();
      }
   }

   public enum WeaponCategory
   {
      Slice, Bludgeon, Shoot, Explosive, Specialized
   }
}
