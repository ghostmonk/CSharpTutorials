using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Hierarchies
{
    class Rectangle : IShape
    {
        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Print()
        {
            Console.WriteLine("Calling Print");
        }

        public void Draw()
        {
            Console.WriteLine("Calling Draw");
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("Calling IPrintable.Draw");
        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Calling IDrawable.Draw");
        }
    }
}
