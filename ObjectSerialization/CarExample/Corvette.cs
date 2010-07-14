using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ObjectSerialization.CarExample
{
   [Serializable]//, XmlRoot(Namespace = "http://wwwghostmonk.com")]
   public class Corvette : Car
   {
      public Corvette( int maxSpeed, bool hasNitro )
      {
         MaxSpeed = maxSpeed;
         HasNitro = hasNitro;
      }

      public Corvette(){}

      //[XmlAttribute]
      public int MaxSpeed
      {
         get; set;
      }

      //[XmlAttribute]
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
