using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileIO.FileSystem
{
   class DirectoryUtilities
   {
      public DirectoryUtilities()
      {
         const string baseDir = @"E:\";
         const string genDir = "GeneratedDir";
         const string subDir = "GeneratedSubDir";
         CreateDir( baseDir, genDir );
         CreateDir( baseDir + genDir, subDir );
         ReadLogicalDrives();
         DeleteDirectories( baseDir + genDir + @"\" + subDir );
         ReadDriveStats();

      }

      public static void CreateDir( string baseDir, string newDirName )
      {
         DirectoryInfo dInfo = new DirectoryInfo(baseDir);
         DirectoryInfo subDirInfo = dInfo.CreateSubdirectory( newDirName );
         Console.WriteLine("New Folder is: {0}", subDirInfo);
      }

      public static void DeleteDirectories( string dirName )
      {
         try
         {
            Directory.Delete( dirName );
            Console.WriteLine( "Deleted Following Directory: {0}", dirName );
         }
         catch (Exception e)
         {
            Console.WriteLine(e.Message);
         }
      }

      public static void ReadLogicalDrives()
      {
         string[] drives = Directory.GetLogicalDrives();
         Console.WriteLine("Drives detected on this Computer:");
         foreach (string drive in drives)
            Console.WriteLine("---> {0}", drive);
      }

      public static void ReadDriveStats()
      {
         Console.WriteLine("\n*********** Drive Information **********");
         DriveInfo[] drives = DriveInfo.GetDrives();

         foreach (var driveInfo in drives)
         {
            Console.WriteLine( "Name: {0}", driveInfo.Name );
            Console.WriteLine( "Type: {0}", driveInfo.DriveType );

            if( driveInfo.IsReady )
            {
               Console.WriteLine( "Free Space: {0}", driveInfo.TotalFreeSpace );
               Console.WriteLine( "Format: {0}", driveInfo.DriveFormat );
               Console.WriteLine( "Label: {0}", driveInfo.VolumeLabel );
            }
            Console.WriteLine();
         }
      }
   }
}
