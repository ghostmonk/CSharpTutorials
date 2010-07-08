using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Graphic
{
    public class Triangle : Shape, IPointy
    {
        public Triangle()
            : base("Triangle")
        {
        }

        public byte Points
        {
            get { return 3; }
        }
    }
}
