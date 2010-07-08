using System.Collections.Generic;

namespace CollectionsGenerics.CollectionsGenerics.Generics.Universe
{
   interface ISolarSystem<T> : IEnumerable<T> where T : Planet
   {
      List<T> Planets { get; }
      void AddPlanet(T planet);
      bool DestroyPlanet(T planet);
      int CountPlanets();
      void ClearSystem();
   }
}
