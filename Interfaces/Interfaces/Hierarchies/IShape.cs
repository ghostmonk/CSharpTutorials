using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Hierarchies
{
    interface IShape : IPrintable, IDrawable
    {
        int GetNumberOfSides();
    }
}
