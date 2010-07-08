using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CollectionsGenerics.CollectionsGenerics.Generics.Universe;

namespace CollectionsGenerics.CollectionsGenerics.Generics
{
   class GalacticFederation
   {
      private AlienSolarSystem alienSystem;
      private HumanSolarSystem humanSystem;

      public GalacticFederation()
      {
         this.CreateHumanSolarSystem();
         this.CreateAlienSolarSystem();
         AttackHostileAlienPlanets();
         VisitAllHumanPlanets();
      }

      private void AttackHostileAlienPlanets()
      {
         foreach( AlienPlanet planet in this.alienSystem )
            if( planet.IsThreatToEarth )
               planet.Attack();
      }

      private void VisitAllHumanPlanets()
      {
         foreach (HumanPlanet planet in this.humanSystem)
            if (!planet.VisitedByMan)
               this.humanSystem.VisitPlanet(planet);
      }

      private void CreateHumanSolarSystem()
      {
         List<string> animals = new List<string>();
         animals.Add( "Tiger" );
         animals.Add( "Jaguar" );
         animals.Add( "Bison" );
         animals.Add( "Wild Pig" );

         this.humanSystem = new HumanSolarSystem();
         this.humanSystem.AddPlanet( new HumanPlanet( "Saturn", true ) );
         this.humanSystem.AddPlanet( new HumanPlanet( "Venus" ) );
         this.humanSystem.AddPlanet( new HumanPlanet( "Mercury" ) );
         this.humanSystem.AddPlanet( new HumanPlanet( "Neptune" ) );
         this.humanSystem.AddPlanet( new HumanPlanet( "Mars", true ) );
         this.humanSystem.AddPlanet( new HumanPlanet( "Jupiter", true ) );
         this.humanSystem.AddPlanet( new HumanPlanet( "Earth", true, animals ) );
      }

      private void CreateAlienSolarSystem()
      {
         List<string> animals = new List<string>();
         animals.Add( "Tregor" );
         animals.Add( "Antaguar" );
         animals.Add( "Biron" );
         animals.Add( "Wild Porgy" );

         this.alienSystem = new AlienSolarSystem();
         this.alienSystem.AddPlanet( new AlienPlanet( "Xazorg", true ) );
         this.alienSystem.AddPlanet( new AlienPlanet( "Zoorgulo" ) );
         this.alienSystem.AddPlanet( new AlienPlanet( "Pangwongu" ) );
         this.alienSystem.AddPlanet( new AlienPlanet( "Qezwangar", true ) );
         this.alienSystem.AddPlanet( new AlienPlanet( "Mukbatchean" ) );
         this.alienSystem.AddPlanet( new AlienPlanet( "Orxangulon" ) );
         this.alienSystem.AddPlanet( new AlienPlanet( "Cheruba", true, animals ) );
      }
   }
}
