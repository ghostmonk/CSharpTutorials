using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace Interfaces.Interfaces.Cloning
{
    class Flora : ICloneable
    {
        private StringCollection _plants = new StringCollection();
        private string _name;
        private int _population;

        public Flora( string name )
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
            set { _plants = value; }
        }

        public StringCollection ListClone
        {
            get
            {
                StringCollection output = new StringCollection();
                foreach (string plant in _plants)
                    output.Add(plant);
                return output;
            }
        }

        public void AddPlant(string plant)
        {
            _plants.Add(plant);
        }

        public void RemovePlant(string plant)
        {
            _plants.Remove(plant);
        }

        public void Display()
        {
            Console.WriteLine("Flora Description:");
            Console.WriteLine("Name: {0}", _name);
            Console.WriteLine("Population: {0}", _population);
            Console.Write("Plants: ");
            foreach (string plant in _plants)
                Console.Write(plant + ", ");
            Console.WriteLine();
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
