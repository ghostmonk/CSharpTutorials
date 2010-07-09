using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;

namespace IsolatedStorageSaver.Utils
{
   class IsoDataUtils
   {
      public static void SaveUserAssemblyData( string fileName, string data )
      {
         using (IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForAssembly())
         {
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream( fileName, FileMode.OpenOrCreate, isoFile ))
            {
               using (StreamWriter streamWriter = new StreamWriter( isoStream ))
               {
                  streamWriter.Write( data );
               }
            }
         }
      }

      public static string ReadUserAssemblyData(string fileName)
      {
         using (IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForAssembly())
         {
            using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream( fileName, FileMode.Open, FileAccess.Read, isoFile ))
            {
               using (StreamReader reader = new StreamReader( stream ))
               {
                  return reader.ReadToEnd();
               }
            }
         }
      }

      public static void CreateCustomUserStorage( string directory )
      {
         using (IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForAssembly())
         {
            isoFile.CreateDirectory( directory );
         }
      }

      public static void DeleteUserAssemblyData()
      {
         IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForAssembly();
         isoFile.Remove();
      }
   }
}
