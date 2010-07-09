using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectContext.ContextReaders;

namespace ObjectContext
{
    class Program
    {
        static void Main(string[] args)
        {
            new ThreadSafeContextReader();
            new NormalContextReader();
            Console.ReadLine();
        }
    }
}
