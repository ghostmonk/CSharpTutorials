using System.Collections.Generic;

namespace CollectionsGenerics.CollectionsGenerics.Generics.Universe
{
   class HumanPlanet : Planet
   {
      private bool visitedByMan;

      public bool VisitedByMan
      {
         get { return this.visitedByMan; }
         set { this.visitedByMan = value; }
      }

      public HumanPlanet(string name, bool visitedByMan) : this( name, visitedByMan, new List<string>() ) { }
      
      public HumanPlanet(string name, bool visitedByMan, List<string> animals) : base( name, animals )
      {
         this.visitedByMan = visitedByMan;
      }

      public HumanPlanet(string name) : base( name )
      {
         this.visitedByMan = false;
      }
   }
}
