using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MetaDataViewer
{
   class Program
   {
      static void Main(string[] args)
      {
         MetaDataViewer viewer = new MetaDataViewer();

         bool isComplete = false;

         do
         {
            Console.WriteLine("\nEnter a type name to evaluate or enter Q to quit:");
            String typeName = Console.ReadLine();
            
            if( typeName.ToUpper() == "Q")
            {
               isComplete = true;
               break;
            }

            try
            {
               Console.WriteLine( "" );
               viewer.ListTypeInfo(Type.GetType(typeName));
            }
            catch 
            {
               Console.WriteLine("Sorry, can't find type");
            }

         } while (!isComplete);
      }
   }
}