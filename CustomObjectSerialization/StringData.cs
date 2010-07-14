using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CustomObjectSerialization
{
   [Serializable]
   class StringData : ISerializable
   {
      private string dataItemOne = "First Data Block";
      private string dataItemTwo = "Second Data Block";

      public StringData(){}
      public StringData(SerializationInfo info, StreamingContext context)
      {
         dataItemOne = info.GetString( "First_Item" ).ToLower();
         dataItemTwo = info.GetString( "dataItemTwo" ).ToLower();
      }

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

      void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
      {
         info.AddValue( "First_Item", dataItemOne.ToUpper() );
         info.AddValue( "dataItemTwo", dataItemTwo.ToUpper() );
      }
   }
}
