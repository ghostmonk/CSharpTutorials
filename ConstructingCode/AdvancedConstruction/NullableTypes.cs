using System;

namespace ConstructingCode.AdvancedConstruction
{
   class NullableTypes
   {
      public NullableTypes()
      {
         int? nullableInt = null;
         double? nullableDbl = null;
         bool? nullableBool = null;
         char? nullableChar = null;
         int?[] arrayOfNulls = new int?[10];

         Nullable<int> fullNullInt = null;
         Nullable<double> fullNullDbl = null;
         Nullable<bool> fullNullBool = null;
         Nullable<char> fullNullChar = null;
         Nullable<int>[] fullNullAry = new int?[10];

         Console.WriteLine( nullableInt );
         Console.WriteLine( nullableDbl );
         Console.WriteLine( nullableBool );
         Console.WriteLine( nullableChar );
         Console.WriteLine( arrayOfNulls );

         Console.WriteLine( fullNullInt );
         Console.WriteLine( fullNullDbl );
         Console.WriteLine( fullNullBool );
         Console.WriteLine( fullNullChar );
         Console.WriteLine( fullNullAry );

         DatabaseReader dbReader = new DatabaseReader();

         int? value = dbReader.numericValue;
         if( value.HasValue )
            Console.WriteLine("Value of numeric on DB = " + value);
         else
            Console.WriteLine( "Value of numeric on DB = undefined" );

         bool? bValue = dbReader.boolValue;
         if( bValue != null )
            Console.WriteLine("Boolean is equal to {0}", bValue );
         else
            Console.WriteLine( "Boolean value is undefined" );

         int? guardedData = dbReader.numericValue ?? 100;
         Console.WriteLine( guardedData );

         Console.ReadLine();
      }
   }

   class DatabaseReader
   {
      public DatabaseReader()
      {
         numericValue = null;
         boolValue = true;
      }

      public int? numericValue
      {
         get; set;
      }

      public bool? boolValue
      {
         get; set;
      }
   }
}
