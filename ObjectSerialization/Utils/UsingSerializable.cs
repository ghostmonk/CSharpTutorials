using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ObjectSerialization.Utils
{
   class UsingSerializable
   {
      public UsingSerializable()
      {
         SaveUserPrefs();
      }

      private void SaveUserPrefs()
      {
         UserPrefs userPrefs = new UserPrefs();
         userPrefs.WindowColor = "Yellow";
         userPrefs.FontSize = 50;

         BinaryFormatter binFormat = new BinaryFormatter();

         using(Stream stream = new FileStream("user.dat", FileMode.Create, FileAccess.Write, FileShare.None))
         {
            binFormat.Serialize(stream, userPrefs);
         }
      }
   }
}
