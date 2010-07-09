using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading.ParamThreadDelegate
{
    class ParamThreads
    {
        public ParamThreads()
        {
            Console.WriteLine(" ******* Using ParameterizedThreadStart ******* ");
            Console.WriteLine("ID of Containing Thread = {0}.", Thread.CurrentThread.ManagedThreadId);
            ParamValueObject data = new ParamValueObject(10, 10);
            Thread thread = new Thread(new ParameterizedThreadStart(Execute));
            thread.Start(data);
        }

        public static void Execute(object data)
        {
            if (data is ParamValueObject)
            {
                Console.WriteLine("ParamThreads.Execute Thread ID = {0}", Thread.CurrentThread.ManagedThreadId);
                ParamValueObject parameterData = (ParamValueObject)data;
                int answer = parameterData.X + parameterData.Y;
                Console.WriteLine("{0} + {1} = {2}", parameterData.X, parameterData.Y, answer);
            }
        }
    }
}
