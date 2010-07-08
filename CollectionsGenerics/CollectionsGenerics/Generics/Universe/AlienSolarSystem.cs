using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsGenerics.CollectionsGenerics.Generics.Universe
{
   class AlienSolarSystem : ISolarSystem<AlienPlanet>
   {
      private List<AlienPlanet> planets = new List<AlienPlanet>();

      public List<AlienPlanet> Planets
      {
         get { return this.planets; }
      }

      public void AddPlanet(AlienPlanet planet)
      {
         this.planets.Add( planet );
      }

      public bool DestroyPlanet(AlienPlanet planet)
      {
         return this.planets.Remove( planet );
      }

      public int CountPlanets()
      {
         return this.planets.Count;
      }

      public void ClearSystem()
      {
         this.planets.Clear();
      }

      public void AttackPlanet( AlienPlanet planet )
      {
         planet.Attack();
         planet.IsThreatToEarth = true;
      }

      public IEnumerator<AlienPlanet> GetEnumerator()
      {
         return this.planets.GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}
