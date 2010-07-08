using System;

namespace PolymorpAndParitals.Classes
{
   class ObjectType
   {
      public ObjectType()
      {
         Console.WriteLine("To String: {0}", ToString());
         Console.WriteLine("Get Hash Code: {0}", GetHashCode());
         Console.WriteLine("Get Type: {0}", GetType());
      }

      public override string ToString()
      {
         return "I am an Object Type";
      }

      public override int GetHashCode()
      {
         return 99999;
      }

   }
}
