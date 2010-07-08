using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LateBinding.SmallExamples
{
   class GetAttributesLateBinding
   {
      public GetAttributesLateBinding()
      {
         Console.WriteLine("Using late binding to get attributes.");

         Assembly assembly = Assembly.Load("RPGCharacters");

         Type characterType = assembly.GetType("RPGCharacters.CharacterDescriptionAttribute");
         PropertyInfo propDesc = characterType.GetProperty("Description");

         Type[] types = assembly.GetTypes();

         foreach( Type type in types )
         {
            foreach (object obj in type.GetCustomAttributes( characterType, false ))
               Console.WriteLine("-> {0}: {1}\n", type.Name, propDesc.GetValue(obj, null));
         }
      }
   }
}
