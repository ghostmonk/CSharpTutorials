using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateBinding.SmallExamples
{
   class CustomDescriptionAttribute : System.Attribute
   {
      public CustomDescriptionAttribute(string desc)
      {
         Description = desc;
      }
      public CustomDescriptionAttribute(){}

      public string Description { get; set; }
   }
}
