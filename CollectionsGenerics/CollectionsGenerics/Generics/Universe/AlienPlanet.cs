using System;
using System.Collections.Generic;

namespace CollectionsGenerics.CollectionsGenerics.Generics.Universe
{
   class AlienPlanet : Planet 
   {
      private bool isThreatToEarth;

      public bool IsThreatToEarth
      {
         get { return this.isThreatToEarth; }
         set { this.isThreatToEarth = value; }
      }

      public AlienPlanet(string name, bool isThreatToEarth) : this( name, isThreatToEarth, new List<string>() ) { }

      public AlienPlanet( string name, bool isThreatToEarth, List<string> animals ) : base( name, animals )
      {
         this.isThreatToEarth = isThreatToEarth;
      }

      public AlienPlanet( string name ) : base( name )
      {
         this.isThreatToEarth = false;
      }

      public void Attack()
      {
         Console.WriteLine( "Attacking Alien Planet {0}", Name );
      }

   }
}
