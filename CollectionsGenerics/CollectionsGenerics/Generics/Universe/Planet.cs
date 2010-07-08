using System.Collections.Generic;

namespace CollectionsGenerics.CollectionsGenerics.Generics.Universe
{
   class Planet
   {
      private string name;
      private List<string> animals;

      public Planet( string name, List<string> animals ) : this(name)
      {
         animals.AddRange(animals);
      }

      public Planet( string name )
      {
         this.name = name;   
         animals = new List<string>();
      }

      public void AddAnimal(string animal)
      {
         this.animals.Add(animal);
      }

      public string Name
      {
         get { return this.name; }
      }

      public bool hasLife
      {
         get { return this.animals.Count > 0; }
      }
   }
}
