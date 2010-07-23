using System;
using System.Collections.Generic;

namespace CollectionsGenerics.CollectionsGenerics.Generics.Universe
{
   class AlienPlanet : Planet 
   {
      public bool IsThreatToEarth { get; set; }

      public AlienPlanet(string name, bool isThreatToEarth) : this( name, isThreatToEarth, new List<string>() ) { }

      public AlienPlanet( string name, bool isThreatToEarth, List<string> animals ) : base( name, animals )
      {
         this.IsThreatToEarth = isThreatToEarth;
      }

      public AlienPlanet( string name ) : base( name )
      {
         this.IsThreatToEarth = false;
      }

      public void Attack()
      {
         Console.WriteLine( "Attacking Alien Planet {0}", Name );
      }

   }
}
