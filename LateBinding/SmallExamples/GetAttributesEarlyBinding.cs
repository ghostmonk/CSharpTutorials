using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGCharacters.Races;

namespace LateBinding.SmallExamples
{
   class GetAttributesEarlyBinding
   {
      public GetAttributesEarlyBinding()
      {
         Type type = typeof (UsingSerializable);
         object[] customAtts = type.GetCustomAttributes(false);
         
         Console.WriteLine("Custom attributes for UsingSerializable");
         foreach (CustomDescriptionAttribute attribute in customAtts)
            Console.WriteLine("-> {0}\n", attribute.Description);
      }
   }
}
