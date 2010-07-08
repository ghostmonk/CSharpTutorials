using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Graphic
{
    class Hexagon : Shape, IPointy
    {
        public Hexagon()
            : base("Hexagon")
        {
        }
        public byte Points
        {
            get { return 6; }
        }
    }
}
