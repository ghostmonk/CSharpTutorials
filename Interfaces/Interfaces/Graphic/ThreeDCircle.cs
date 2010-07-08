using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Graphic
{
    public class ThreeDCircle : Circle, IDraw3D
    {
        public ThreeDCircle()
            : base("ThreeDCircle")
        {
        }

        public void DrawIn3D()
        {
            Console.WriteLine("Drawing in 3D a {0}.", Name);
        }
    }
}
