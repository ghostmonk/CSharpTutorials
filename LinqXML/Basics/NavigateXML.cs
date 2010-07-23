using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinqXML.Basics
{
   class NavigateXML
   {
      private XElement document;

      public NavigateXML()
      {
         document = XElement.Load( "Inventory.xml" );

         PrintPetNames();
         AddNewFord();
         PrintAllFords();
      }

      private void PrintPetNames()
      {
         var petNames = from name in document.Descendants( "PetName" )
                        select name.Value;

         foreach( string name in petNames )
            Console.WriteLine( "Name: {0}", name );
      }

      private void PrintAllFords()
      {
         var fords = from ford in document.Descendants( "Make" )
                     where ford.Value == "Ford"
                     select ford;
         foreach( XElement ford in fords )
            Console.WriteLine( "Name: {0}", ford );
      }

      private void AddNewFord()
      {
         XElement newFord = new XElement( "Car", new XAttribute( "ID", 1001 ) );
         newFord.Add( new XElement( "Color", "Green" ) );
         newFord.Add( new XElement( "Make", "Ford" ) );
         newFord.Add( new XElement( "PetName", "Meh" ) );

         document.Add( newFord );
      }
   }
}
