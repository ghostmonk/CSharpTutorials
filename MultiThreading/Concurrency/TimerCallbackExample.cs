using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading.Concurrency
{
    class TimerCallbackExample
    {
        public TimerCallbackExample()
        {
            Console.WriteLine("********** Using a TimerCallback **********");

            TimerCallback callback = new TimerCallback( PrintTime );

            Timer timer = new Timer(callback, "Here is Transport Data", 0, 1000);

            Console.WriteLine("Hit return to terminate program.");
        }

        private void PrintTime(object state)
        {
            Console.WriteLine("Time: {0}, Info: {1}", DateTime.Now.ToLongTimeString(), state.ToString());
        }
    }
}
