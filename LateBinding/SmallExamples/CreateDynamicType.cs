using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LateBinding.SmallExamples
{
   [CustomDescription( Description = "++++++++++Fun With Late Binding+++++++++++" )]
   class CreateDynamicType
   {
      public CreateDynamicType()
      {
         Assembly a;

         try
         {
            a = Assembly.Load("People");
         }
         catch(FileNotFoundException e)
         {
            Console.WriteLine(e.Message);
            return;
         }

         Type janitorType = a.GetType("People.Janitor");
         object janitor = Activator.CreateInstance(janitorType);
         Console.WriteLine( "Using late binding created {0}", janitor );

         MethodInfo speak = janitorType.GetMethod("Speak");
         MethodInfo sillyMsg = janitorType.GetMethod( "DisplaySomethingSilly" );
         speak.Invoke( janitor, null );
         sillyMsg.Invoke( janitor, new []{ "I once knew a lass from panama." });
      }
   }
}
