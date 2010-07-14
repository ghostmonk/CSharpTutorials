using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectSerialization.CarExample
{
   [Serializable]
   public class Car
   {
      public bool IsHatchBack
      {
         get; set;
      }

      public Radio RadioPlayer
      {
         get; set;
      }
   }
}
