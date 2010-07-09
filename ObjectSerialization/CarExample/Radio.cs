using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectSerialization.CarExample
{
   [Serializable]
   class Radio
   {
      public bool HasTweeters
      {
         get; set;
      }

      public bool HasSubWoofers
      {
         get; set;
      }

      public double[] StationPresets
      {
         get; set;
      }

      [NonSerialized] 
      public string RadioID = "XF-552RR6";

      public override string ToString()
      {
         string presets = "";
         foreach (double station in StationPresets)
            presets += " " + station;
         return string.Format("HasTweeters: {0}\n HasSubWoofers:{1}\n StationPresets:{2}\n ID:{3}\n",
                              HasTweeters, HasSubWoofers, presets, RadioID );
      }
   }
}
