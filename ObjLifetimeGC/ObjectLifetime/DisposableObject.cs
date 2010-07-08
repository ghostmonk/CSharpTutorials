using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjLifetimeGC.ObjectLifetime
{
    class DisposableObject : IDisposable
    {
        private bool disposed = false;

        public void WriteOut(string value)
        {
            Console.WriteLine(value);
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing: {0}", GetHashCode());
            CleanUp(true);
            GC.SuppressFinalize(this);
        }

        ~DisposableObject()
        {
            Console.WriteLine("Killing: {0}", GetHashCode());
            CleanUp(false);
        }
        
        //This function is responsible for cleaning up resources
        private void CleanUp(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    Console.WriteLine("Cleanup Managed: {0}", GetHashCode());
            Console.WriteLine("Cleanup UnManaged: {0}", GetHashCode());
            disposed = true;
        }
    }
}
