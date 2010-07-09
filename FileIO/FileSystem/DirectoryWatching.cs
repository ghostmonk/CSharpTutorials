using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileIO.FileSystem
{
   internal class DirectoryWatching
   {
      public DirectoryWatching()
      {
         FileSystemWatcher systemWatcher = new FileSystemWatcher();
         systemWatcher.Path = Environment.CurrentDirectory;
         systemWatcher.NotifyFilter = NotifyFilters.LastAccess
                                      | NotifyFilters.LastWrite
                                      | NotifyFilters.FileName
                                      | NotifyFilters.DirectoryName;
         systemWatcher.Filter = "*.txt";

         systemWatcher.Changed += OnChanged;
         systemWatcher.Created += OnChanged;
         systemWatcher.Deleted += OnChanged;
         systemWatcher.Renamed += OnRenamed;

         systemWatcher.EnableRaisingEvents = true;
         while (Console.Read() != 'q') ;
      }

      private void OnChanged(object source, FileSystemEventArgs e)
      {
         Console.WriteLine("File: {0} {1}!", e.FullPath, e.ChangeType);
      }

      private void OnRenamed(object sender, RenamedEventArgs e)
      {
         Console.WriteLine("File: {0} renamed to {1}!", e.OldFullPath, e.FullPath);
      }
   }
}