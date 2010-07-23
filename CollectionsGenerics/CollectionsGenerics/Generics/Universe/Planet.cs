using System.Collections.Generic;

namespace CollectionsGenerics.CollectionsGenerics.Generics.Universe
{
   class Planet
   {
      private List<string> animals;

      public Planet( string name, List<string> animals ) : this(name)
      {
         animals.AddRange(animals);
      }

      public Planet( string name )
      {
         this.Name = name;   
         animals = new List<string>();
      }

      public void AddAnimal(string animal)
      {
         this.animals.Add(animal);
      }

      public string Name { get; private set; }

      public bool hasLife
      {
         get { return this.animals.Count > 0; }
      }
   }
}
