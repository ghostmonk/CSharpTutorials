using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileIO.FileSystem
{
   class FileUtilities
   {
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
         baseDir = baseDir.EndsWith(@"\") ? baseDir : baseDir + @"\";
         FileInfo info = new FileInfo(baseDir + fileName);
         Console.WriteLine( "Created new File: {0}", baseDir + fileName );
         using ( info.Create() )
         {
            
         }
      }

      public static void OpenFile( string baseDire, string fileName )
      {
         
      }
   }
}
