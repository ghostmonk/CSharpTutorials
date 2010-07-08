using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsGenerics.CollectionsGenerics.Generics.Universe
{
   class HumanSolarSystem : ISolarSystem<HumanPlanet>
   {
      private List<HumanPlanet> planets = new List<HumanPlanet>();

      public List<HumanPlanet> Planets
      {
         get { return this.planets; }
      }

      public void AddPlanet(HumanPlanet planet)
      {
         this.planets.Add(planet);
      }

      public bool DestroyPlanet(HumanPlanet planet)
      {
         return this.planets.Remove(planet);
      }

      public int CountPlanets()
      {
         return this.planets.Count;
      }

      public void ClearSystem()
      {
         this.planets.Clear();
      }

      public void VisitPlanet(HumanPlanet planet)
      {
         Console.WriteLine( "Visiting Planet {0}", planet.Name);
         planet.VisitedByMan = true;
      }

      public IEnumerator<HumanPlanet> GetEnumerator()
      {
         return this.planets.GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}
