using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;

namespace CustomObjectSerialization
{
   class SerializerAction
   {
      public SerializerAction()
      {
         Serialize(new StringData(), "BlanketFormatter.xml");
         Serialize(new MoreData(), "EventFormatter.xml");
      }

      private void Serialize( object obj, String fileName )
      {
         SoapFormatter formatter = new SoapFormatter();
         using (Stream stream = new FileStream( fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None ))
         {
            formatter.Serialize( stream, obj );
            stream.Seek(0, SeekOrigin.Begin);
            formatter.Deserialize(stream);
         }
         Console.WriteLine("{0} Serialized to {1}", obj, fileName);
      }
   }
}
