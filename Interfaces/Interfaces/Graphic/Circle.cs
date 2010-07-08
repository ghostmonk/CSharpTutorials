using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Graphic
{
    public class Circle : Shape
    {
        public Circle()
            : base("Circle")
        {
        }

        protected Circle( string name )
            : base(name){}
    }
}
