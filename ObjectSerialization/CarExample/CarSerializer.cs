using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;

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
         string CorvetteSoapFile = "SoapCorvetteData.dat";
         SaveAsBinaryFormat( corvette, CorvetteBinFile );
         ReadBinaryFile( CorvetteBinFile );

         SaveAsSoapFormat(corvette, CorvetteSoapFile);
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
   }
}
