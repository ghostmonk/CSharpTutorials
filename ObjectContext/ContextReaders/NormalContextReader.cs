﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ObjectContext.ContextReaders
{
    class NormalContextReader
    {
        public NormalContextReader()
        {
            Context context = Thread.CurrentContext;
            Console.WriteLine("{0} object in context {1}", ToString(), context.ContextID);
            foreach (IContextProperty contextProp in context.ContextProperties)
                Console.WriteLine("-> Ctx Prop = {0}", contextProp.Name);
        }
    }
}
