using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace Interfaces.Interfaces.Cloning
{
    class Ecosystem : ICloneable
    {
        private Fauna _fauna;
        private Flora _flora;
        private EcosystemType _type;
        private bool _isHealthy;
        private int _healthRating;

        public Ecosystem( EcosystemType type, Fauna fauna, Flora flora )
        {
            _isHealthy = true;
            _healthRating = 100;
            _type = type;
            _fauna = fauna;
            _flora = flora;
        }

        public Fauna Animals
        {
            get { return _fauna; }
        }

        public Flora Plants
        {
            get { return _flora; }
        }

        public bool IsHealthy
        {
            get { return _isHealthy; }
            set { _isHealthy = value; }
        }

        public int HealthRating
        {
            get { return _healthRating; }
            set { _healthRating = value; }
        }

        public object Clone()
        {
            Ecosystem output = new Ecosystem( _type, (Fauna)_fauna.Clone(), (Flora)_flora.Clone() );
            output.IsHealthy = _isHealthy;
            output.HealthRating = _healthRating;
            output.Animals.List = _fauna.ListClone;
            output.Plants.List = _flora.ListClone;
            return output;
        }

        public EcosystemType type
        {
            set { _type = value; }
        }

        public void Display() 
        {
            Console.WriteLine("Type: {0}", _type);
            Console.WriteLine("Is healthy: {0}", _isHealthy);
            Console.WriteLine("Health Rating: {0}", _healthRating);
            Console.WriteLine("-------------------------");
            _flora.Display();
            Console.WriteLine("-------------------------");
            _fauna.Display();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public enum EcosystemType
    {
        Tundra,
        Desert,
        Forest,
        Grassland,
        Ocean,
        Pond,
        River
    }
}
