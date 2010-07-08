using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjLifetimeGC.ObjectLifetime
{
    class ObjectLifetimeMain
    {
        public ObjectLifetimeMain()
        {
            UsingKeyword();

            DisposableObject item = new DisposableObject();

            new DisposableObject(); 
            
            new GarbageCollection();

            if (item is IDisposable)
                ( item as IDisposable ).Dispose();
        }

        private void UsingKeyword()
        {
            using (DisposableObject disposable = new DisposableObject())
            {
                disposable.WriteOut("Invoking Method on IDisposable instnace.");
            }
        }
    }
}
