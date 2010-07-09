using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectSerialization.CarExample
{
   [Serializable]
   class Corvette : Car
   {
      public int MaxSpeed
      {
         get; set;
      }

      public bool HasNitro
      {
         get; set;
      }

      public override string ToString()
      {
         return string.Format("IsHatchBack:{0}\nMaxSpeed:{1}\nHasNitro{2}\nRadio:\n{3}", 
                              IsHatchBack, MaxSpeed, HasNitro, RadioPlayer);
      }
   }
}
