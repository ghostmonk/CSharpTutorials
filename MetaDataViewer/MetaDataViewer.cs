using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MetaDataViewer
{
   class MetaDataViewer
   {
      public void ListTypeInfo(Type type)
      {
         PrintPropertyInfo( type.GetMethods(), "Methods" );
         PrintPropertyInfo( type.GetFields(), "Fields" );
         PrintPropertyInfo( type.GetProperties(), "Properties" );
         PrintPropertyInfo( type.GetInterfaces(), "Interfaces" );
         PrintVariousStats( type );
      }

      private void PrintPropertyInfo( IEnumerable<MemberInfo> infoList, String sectionTitle )
      {
         Console.WriteLine( "----------{0}----------", sectionTitle );
         foreach (MemberInfo info in infoList)
         {
            Console.Write("->{0}", info.Name);
            if (info is MethodInfo) PrintParameters((info as MethodInfo).GetParameters());
            Console.WriteLine();
         }
         Console.WriteLine();
      }

      private void PrintParameters(IEnumerable<ParameterInfo> infoList)
      {
         Console.Write("( ");
         foreach( ParameterInfo info in infoList )
            Console.Write( "{0} {1} ", info.ParameterType, info.Name);
         Console.WriteLine(")");
      }

      private void PrintVariousStats( Type type )
      {
         Console.WriteLine( "----------Various Stats----------" );
         Console.WriteLine( "Base Class is: {0}", type.BaseType );
         Console.WriteLine( "Is Abstract: {0}", type.IsAbstract );
         Console.WriteLine( "Is Sealed: {0}", type.IsSealed );
         Console.WriteLine( "Is Generic: {0}", type.IsGenericTypeDefinition );
         Console.WriteLine( "Is class Type: {0}", type.IsClass );
         Console.WriteLine();
      }
   }
}
