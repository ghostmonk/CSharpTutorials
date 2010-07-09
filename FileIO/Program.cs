using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileIO.FileSystem;
using FileIO.IsolatedStorage;
using FileIO.UsingFileStream;

namespace FileIO
{
   class Program
   {
      static void Main(string[] args)
      {
         //FileIOStuff();
         IsolatedStorageStuff();
         Console.ReadLine();
      }

      private static void FileIOStuff()
      {
         //new DirectoryReader();
         //new DirectoryUtilities();
         //new FileUtilities();
         //new TaskMaker();
         //new WorkingWithFileStreams();
         //new WriteReadAFile();
         //new StrWritersReaders();
         //new DirectoryWatching();
         new AsyncFileStream();
      }

      private static void IsolatedStorageStuff()
      {
         //new EvidenceReader();
         new SimpleISOStorage();
      }
   }
}
