using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading.Concurrency
{
    class InterlockedOperations
    {
        private int SimpleValue = 1;
        private int ReplaceValue = 3;
        private int CompValue = 25;

        public InterlockedOperations()
        {
            Console.WriteLine("*********Using Interlocked**********");
            
            //Simply incrementing a value
            Interlocked.Increment(ref SimpleValue);
            Console.WriteLine("Using Interlocked.Increment = {0}", SimpleValue);

            //Replacing SimpleValue with ReplaceValue.. they are now equivalent
            Interlocked.Exchange(ref SimpleValue, ReplaceValue);
            Console.WriteLine("Using Interlocked.Exchange = {0}", SimpleValue);

            //Turning SimpleValue into CompValue if SimpleValue == ReplaceValue, which it is (due to the previous operation)
            Interlocked.CompareExchange(ref SimpleValue, CompValue, ReplaceValue);
            Console.WriteLine("Using Interlocked.CompareExchange = {0}", SimpleValue);
        }
    }
}
