using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace Interfaces.Interfaces.Cloning
{
    class Fauna : ICloneable
    {
        private StringCollection _animals = new StringCollection();
        private string _name;
        private int _population;

        public Fauna(string name)
        {
            _name = name;
        }

        public int Population
        {
            get { return _population; }
            set { _population = value; }
        }

        public StringCollection List
        {
            set { _animals = value; }
        }

        public StringCollection ListClone
        {
            get
            {
                StringCollection output = new StringCollection();
                foreach (string animal in _animals)
                    output.Add(animal);
                return output;
            }
        }

        public void AddAnimal(string animal)
        {
            _animals.Add(animal);
        }

        public void RemoveAnimal(string animal)
        {
            _animals.Remove(animal);
        }

        public void Display()
        {
            Console.WriteLine("Fauna Description:");
            Console.WriteLine("Name: {0}", _name);
            Console.WriteLine("Population: {0}", _population);
            Console.Write("Animals: ");
            foreach (string animal in _animals)
                Console.Write(animal + ", ");
            Console.WriteLine();
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
