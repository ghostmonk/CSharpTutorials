using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileIO.FileSystem
{
   class DirectoryReader
   {
      public DirectoryReader()
      {
         const string winDir = @"C:\Windows";
         ShowDirectoryStats( winDir );
      }

      public static void ShowDirectoryStats(string path)
      {
         DirectoryInfo dInfo = new DirectoryInfo(path);
         Console.WriteLine("**** Directory Info for {0} **** ", path);
         Console.WriteLine( "FullName: {0}", dInfo.FullName );
         Console.WriteLine( "Name: {0}", dInfo.Name );
         Console.WriteLine( "Parent: {0}", dInfo.Parent);
         Console.WriteLine( "Creation: {0}", dInfo.CreationTime );
         Console.WriteLine( "Attributes: {0}", dInfo.Attributes );
         Console.WriteLine( "Root: {0}", dInfo.Root );
         Console.WriteLine("***************************************\n");
      }
   }
}
