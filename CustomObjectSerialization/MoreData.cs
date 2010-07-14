using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CustomObjectSerialization
{
   [Serializable]
   class MoreData
   {
      private string dataItemOne = "First Data Block";
      private string dataItemTwo = "Second Data Block";

      public string DataItemOne
      {
         get { return dataItemOne; }
         set { dataItemOne = value; }
      }

      public string DataItemTwo
      {
         get { return dataItemTwo; }
         set { dataItemTwo = value; }
      }

      [OnSerializing]
      private void OnSerializing(StreamingContext context)
      {
         DataItemOne = DataItemOne.ToUpper();
         DataItemTwo = DataItemTwo.ToUpper();
         Console.WriteLine("On Serializing: {0}, {1}", DataItemOne, DataItemTwo);
      }

      [OnDeserialized]
      private void OnDeserialized(StreamingContext context)
      {
         DataItemOne = DataItemOne.ToLower();
         DataItemTwo = DataItemTwo.ToLower();
         Console.WriteLine( "On Deserialized: {0}, {1}", DataItemOne, DataItemTwo );
      }
   }
}
