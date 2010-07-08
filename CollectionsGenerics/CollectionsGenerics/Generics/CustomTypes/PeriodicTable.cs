using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsGenerics.CollectionsGenerics.Generics.CustomTypes
{
   class PeriodicTable<T> : IEnumerable<T>
   {
      private IList<T> elements = new List<T>();

      public int Count
      {
         get { return elements.Count; }
      }

      public T GetElement( int pos )
      {
         return elements[pos];
      }

      public void AddElement( T item )
      {
         elements.Add(item);   
      }

      public bool RemoveElement( T item )
      {
         return elements.Remove(item);
      }

      public void ClearTable()
      {
         elements.Clear();
      }

      IEnumerator<T> IEnumerable<T>.GetEnumerator()
      {
         return elements.GetEnumerator();
      }

      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
      {
         return elements.GetEnumerator();
      }
   }
}
