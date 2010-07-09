using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shapes;

namespace ShapeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.draw();
            Console.ReadLine();
        }
    }
}
