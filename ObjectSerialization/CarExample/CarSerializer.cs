using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Xml.Serialization;

namespace ObjectSerialization.CarExample
{
   class CarSerializer
   {
      public CarSerializer()
      {
         Corvette corvette = new Corvette();
         corvette.HasNitro = true;
         corvette.IsHatchBack = false;
         corvette.MaxSpeed = 500;
         corvette.RadioPlayer = new Radio();
         corvette.RadioPlayer.HasSubWoofers = true;
         corvette.RadioPlayer.HasTweeters = true;
         corvette.RadioPlayer.StationPresets = new double[] { 89.3, 97.9, 103.1 };

         string CorvetteBinFile = "BinCorvetteData.dat";
         string CorvetteSoapFile = "CorvetteSoap.xml";
         string CorvetteXMLFile = "Corvette.xml";
         string CorvetteXMLList = "CorvetteList.xml";
         string CorvetteBinList = "CorvetteList.dat";
         SaveAsBinaryFormat( corvette, CorvetteBinFile );
         ReadBinaryFile( CorvetteBinFile );

         SaveAsSoapFormat(corvette, CorvetteSoapFile);
         SaveAsXmlFormat(corvette, CorvetteXMLFile);
         SerializeList(CorvetteXMLList, CorvetteBinList);
      }

      private void SaveAsBinaryFormat(object objGraph, string fileName)
      {
         BinaryFormatter binFormat = new BinaryFormatter();
         
         using(Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
         {
            binFormat.Serialize(stream, objGraph);
         }

         Console.WriteLine("Corvette has been saved to Binary Format");
      }

      private void ReadBinaryFile( string fileName )
      {
         Console.WriteLine( "\nReading Corvette from Binary Format" );
         BinaryFormatter binaryFormatter = new BinaryFormatter();

         using (Stream stream = File.OpenRead(fileName))
         {
            Corvette corvette = (Corvette) binaryFormatter.Deserialize(stream);
            Console.WriteLine(corvette.ToString());
         }
      }

      private void SaveAsSoapFormat( object objGraph, string fileName )
      {
         SoapFormatter soapFormatter = new SoapFormatter();

         using(Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
         {
            soapFormatter.Serialize(stream, objGraph);
         }

         Console.WriteLine( "Corvette has been saved to Soap Format" );
      }

      private void SaveAsXmlFormat( object obj, string fileName )
      {
         XmlSerializer xmlFormatter = new XmlSerializer( typeof( Corvette ), new Type[] { typeof(Radio), typeof(Car)} );
         using (Stream stream = new FileStream(fileName, FileMode.Create,FileAccess.Write, FileShare.None))
         {
            xmlFormatter.Serialize(stream, obj);
         }
         Console.WriteLine("Corvette saved to XML Format");
      }

      private void SerializeList( string xmlFile, string binFile )
      {
         List<Corvette> corvettes = new List<Corvette>();
         corvettes.Add( new Corvette( 100, true ) );
         corvettes.Add( new Corvette( 100, false ) );
         corvettes.Add( new Corvette( 150, true ) );
         corvettes.Add( new Corvette( 150, false ) );

         using (Stream stream = new FileStream( xmlFile, FileMode.Create, FileAccess.Write, FileShare.None ))
         {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Corvette>), new Type[]{typeof(Corvette), typeof(Car), typeof(Radio)});
            xmlSerializer.Serialize(stream, corvettes);
         }

         using (Stream binStream = new FileStream( binFile, FileMode.Create, FileAccess.Write, FileShare.None))
         {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(binStream, binFile);
         }
         Console.WriteLine("Corvettes Serialized");
      }
   }
}