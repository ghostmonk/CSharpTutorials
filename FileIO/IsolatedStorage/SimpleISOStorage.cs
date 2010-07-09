using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;

namespace FileIO.IsolatedStorage
{
   class SimpleISOStorage
   {
      private const string StoreFile = "IsoData.txt";

      public SimpleISOStorage()
      {
         Console.WriteLine( "**********Storage Being Created**********" );
         WriteTextToIsoStorage();
         ReadFromIsoStorage();
         CreateCustomDirectory();
         Console.WriteLine( "**********Press enter to Delete Storage**********" );
         Console.ReadLine();
         DeleteStore();
         Console.WriteLine( "**********Storage No Longer Exists**********" );
      }

      private void WriteTextToIsoStorage()
      {
         using(IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForAssembly())
         {
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream( StoreFile, FileMode.OpenOrCreate, isoFile ))
            {
               using(StreamWriter streamWriter = new StreamWriter(isoStream))
               {
                  streamWriter.WriteLine("This is some saved custom data");
                  streamWriter.WriteLine("So very very cool");
               }
            }
         }
      }

      private void ReadFromIsoStorage()
      {
         using (IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForAssembly())
         {
            using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream( StoreFile, FileMode.Open, FileAccess.Read, isoFile))
            {
               using (StreamReader reader = new StreamReader(stream))
               {
                  string allData = reader.ReadToEnd();
                  Console.WriteLine(allData);
               }
            }
         }
      }

      private void DeleteStore()
      {
         IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForAssembly();
         isoFile.Remove();
      }

      private void CreateCustomDirectory()
      {
         using(IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForAssembly())
         {
            isoFile.CreateDirectory( @"CustomDir\XmlData" );
            isoFile.CreateDirectory( "CustomDir\\BinaryData" );
            isoFile.CreateDirectory( "CustomDir/TextData" );
         }
      }
   }
}
