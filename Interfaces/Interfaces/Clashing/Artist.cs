using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Clashing
{
    class Artist : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Calling Draw To Form");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Calling Draw To Memory");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Calling Draw To Printer");
        }
    }
}
