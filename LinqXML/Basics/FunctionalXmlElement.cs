using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinqXML.Basics
{
   class FunctionalXmlElement
   {
      public FunctionalXmlElement()
      {
         //CreateXMLDocument();
         //CreateXmlFromArray();
         LoadExistingXML();
      }

      private void LoadExistingXML()
      {
         string stringXML =
            @"<Car ID = '3'>
               <Color>Yellow</Color>
               <Make>Yugo</Make>
            </Car>";
         XElement element = XElement.Parse( stringXML );
         Console.WriteLine( element );

         XDocument doc = XDocument.Load( "AutoLotInventory.XML" );
         Console.WriteLine( doc );
      }

      private void CreateXmlFromArray()
      {
         var data = new[] {
            new { PetName = "Melvin", ID = 10 },
            new { PetName = "Pat", ID = 11 },
            new { PetName = "Danny", ID = 12 },
            new { PetName = "Clunker", ID = 13 },
         };

         XElement vehicles = new XElement( "Inventory",
            from car in data
            select new XElement( "Car",
               new XAttribute( "ID", car.ID ),
               new XElement( "PetName", car.PetName )
            )
         );
         Console.WriteLine( vehicles );
      }

      private void CreateXMLDocument()
      {
         XDocument document = new XDocument();
         document.Declaration = new XDeclaration( "1.0", Encoding.UTF8.ToString(), "yes" );
         document.Add( new XComment( "Current Inventory of AutoLot" ) );

         XElement inventory = new XElement( "Inventory" );
         inventory.Add( CarElement( "1", "Green", "BMW", "Stan" ) );
         inventory.Add( CarElement( "2", "Pink", "Yugo", "Melvin" ) );

         document.Add( inventory );

         Console.WriteLine( document );
         document.Save( "AutoLotInventory.xml" );
      }

      private XElement CarElement( string id, string color, string make, string name )
      {
         XElement car = new XElement( "Car", new XAttribute( "ID", id ) );
         XElement xColor = new XElement( "Color", color );
         XElement xMake = new XElement( "Make", make );
         XElement xName = new XElement( "PetName", name );
         car.Add( xColor );
         car.Add( xMake );
         car.Add( xName );
         return car;
      }
   }
}
