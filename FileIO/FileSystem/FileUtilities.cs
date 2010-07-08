using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileIO.FileSystem
{
   class FileUtilities
   {
      public FileUtilities()
      {
         const string picDir = @"C:\Users\Public\Pictures\Sample Pictures";
         GetFileInfo( picDir, "jpg" );
         CreateFile( Environment.CurrentDirectory, "Test.dat" );
      }

      public static void GetFileInfo( string dir, string extention )
      {
         DirectoryInfo dInfo = new DirectoryInfo( dir );
         string cleanEx = extention.StartsWith("*.") ? extention : "*." + extention;
         FileInfo[] files = dInfo.GetFiles( cleanEx );

         Console.WriteLine("Found {0} {1} files\n", files.Length, cleanEx);

         foreach (FileInfo fileInfo in files)
         {
            Console.WriteLine( "***********************" );
            Console.WriteLine( "File name: {0}", fileInfo.Name );
            Console.WriteLine( "Size: {0}", fileInfo.Length );
            Console.WriteLine( "Creation: {0}", fileInfo.CreationTime );
            Console.WriteLine( "Attributes: {0}", fileInfo.Attributes );
            Console.WriteLine( "***********************\n" );
         }
      }

      public static void CreateFile(string baseDir, string fileName)
      {
         FileInfo fileInfo = ResolveFileInfo( baseDir, fileName );
         Console.WriteLine( "Created new File: {0}", baseDir + fileName );
         using (FileStream fs = fileInfo.Create())
         {
            
         }
      }

      public static void OpenFile( string baseDir, string fileName )
      {
         FileInfo fileInfo = ResolveFileInfo( baseDir, fileName );
         using (FileStream stream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
         {
            
         }
      }

      public static void ReadFile( string baseDir, string fileName )
      {
         FileInfo fileInfo = ResolveFileInfo( baseDir, fileName );
         using ( FileStream stream = fileInfo.OpenRead())
         {
            
         }
      }

      public static void WriteFile(string baseDir, string fileName)
      {
         FileInfo fileInfo = ResolveFileInfo( baseDir, fileName );
         using (FileStream stream = fileInfo.OpenWrite())
         {

         }
      }

      public static void CreateText(string baseDir, string fileName)
      {
         FileInfo fileInfo = ResolveFileInfo( baseDir, fileName );
         using (StreamWriter stream = fileInfo.CreateText())
         {

         }
      }

      public static void AppendText(string baseDir, string fileName)
      {
         FileInfo fileInfo = ResolveFileInfo( baseDir, fileName );
         using (StreamWriter stream = fileInfo.AppendText())
         {

         }
      }

      public static void OpenText(string baseDir, string fileName)
      {
         FileInfo fileInfo = ResolveFileInfo( baseDir, fileName );
         using (StreamReader stream = fileInfo.OpenText())
         {

         }
      }

      private static FileInfo ResolveFileInfo(string baseDir, string fileName)
      {
         baseDir = baseDir.EndsWith( @"\" ) ? baseDir : baseDir + @"\";
         return new FileInfo( baseDir + fileName );
      }
   }
}
