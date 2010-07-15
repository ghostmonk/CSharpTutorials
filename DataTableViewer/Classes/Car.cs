using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTableViewer.Classes
{
   class Car
   {
      public Car( string name, string make, string color )
      {
         Name = name;
         Make = make;
         Color = color;
      }

      public string Color
      {
         get; set;
      }

      public string Make
      {
         get; set;
      }

      public string Name
      {
         get; set;
      }
   }
}
