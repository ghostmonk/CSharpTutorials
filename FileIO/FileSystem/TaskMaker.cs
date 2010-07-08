using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileIO.FileSystem
{
   class TaskMaker
   {
      public TaskMaker()
      {
         Console.WriteLine("**********Creating a Task List*********");
         
         string[] basicTasks = {"Walk the Dog", "Clean the Basement", "Feed The Kids", "Drown The Cats"};
         string fileLoc = Environment.CurrentDirectory + @"\tasks.txt";

         File.WriteAllLines( fileLoc, basicTasks );

         foreach (var task in File.ReadAllLines( fileLoc ))
            Console.WriteLine("TODO: {0}", task);
      }
   }
}
