using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileIO.FileSystem;

namespace FileIO
{
   class Program
   {
      static void Main(string[] args)
      {
         const string baseDir = @"E:\";
         const string genDir = "GeneratedDir";
         const string subDir = "GeneratedSubDir";
         const string winDir = @"C:\Windows";
         const string picDir = @"C:\Users\Public\Pictures\Sample Pictures";

         DirectoryReader.ShowDirectoryStats( winDir );
         FileUtilities.GetFileInfo( picDir,"jpg");
         DirectoryUtilities.CreateDir( baseDir, genDir );
         DirectoryUtilities.CreateDir( baseDir + genDir, subDir );
         DirectoryUtilities.ReadLogicalDrives();
         DirectoryUtilities.DeleteDirectories( baseDir + genDir + @"\" + subDir );
         DirectoryUtilities.ReadDriveStats();
         FileUtilities.CreateFile(baseDir + genDir, "Test.dat");
         Console.ReadLine();
      }
   }
}
