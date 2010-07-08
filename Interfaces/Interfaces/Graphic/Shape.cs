using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Graphic
{
    public abstract class Shape
    {
        private string _name;

        public Shape(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public virtual void Draw()
        {
            IDraw3D item = (this as IDraw3D);

            if (item != null)
                item.DrawIn3D();
            else 
                Console.WriteLine("Drawing {0}", _name);
        }
    }
}
