using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGCharacters
{
   class CharacterDescriptionAttribute : Attribute
   {
      public CharacterDescriptionAttribute( string description )
      {
         Description = description;
      }
      public CharacterDescriptionAttribute(){}

      public string Description
      {
         get; set;
      }
   }
}
