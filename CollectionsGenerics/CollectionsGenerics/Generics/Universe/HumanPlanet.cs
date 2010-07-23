using System.Collections.Generic;

namespace CollectionsGenerics.CollectionsGenerics.Generics.Universe
{
   class HumanPlanet : Planet
   {
      public bool VisitedByMan { get; set; }

      public HumanPlanet(string name, bool visitedByMan) : this( name, visitedByMan, new List<string>() ) { }
      
      public HumanPlanet(string name, bool visitedByMan, List<string> animals) : base( name, animals )
      {
         this.VisitedByMan = visitedByMan;
      }

      public HumanPlanet(string name) : base( name )
      {
         this.VisitedByMan = false;
      }
   }
}
