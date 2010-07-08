using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExceptionsErrors.Errors;

namespace ObjLifetimeGC.ObjectLifetime
{
    class GarbageCollection
    {
        public GarbageCollection()
        {
            Console.WriteLine("Bytes on Heap: {0}", GC.GetTotalMemory(false));
            Console.WriteLine("Object Generations: {0}", GC.MaxGeneration + 1);

            Car car = new Car();
            Console.WriteLine(car.ToString());

            Console.WriteLine("Car generation Ref: {0}", GC.GetGeneration(car));

            object[] objectPool = new object[5000000];
            for (int i = 0; i < objectPool.Length; i++)
                objectPool[i] = new object();

            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Car generation Ref: {0}", GC.GetGeneration(car));

            if (objectPool[0] != null)
                Console.WriteLine("Object 0 is Generation: {0}", GC.GetGeneration(objectPool[0]));
            else
                Console.WriteLine("Object 0 has been collected");

            Console.WriteLine("Generation Sweeps:");
            Console.WriteLine("0:{0}", GC.CollectionCount(0));
            Console.WriteLine("1:{0}", GC.CollectionCount(1));
            Console.WriteLine("2:{0}", GC.CollectionCount(2));
        }
    }
}
