using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsGenerics.CollectionsGenerics.Generics.CustomTypes
{
   class Musketeers<T> where T : Element
   {
      private T athos;
      private T porthos;
      private T aramis;

      public Musketeers( T athos, T porthos, T aramis )
      {
         this.athos = athos;
         this.porthos = porthos;
         this.aramis = aramis;
      }

      public T Athos
      {
         get { return this.athos; }
         set { this.athos = value; }
      }

      public T Porthos
      {
         get { return this.porthos; }
         set { this.porthos = value; }
      }

      public T Aramis
      {
         get { return this.aramis; }
         set { this.aramis = value; }
      }

      public override string ToString()
      {
         return string.Format("Athos:{0}, Porthos:{1}, Aramis:{2}.", athos, porthos, aramis);
      }

      public void Reset()
      {
         athos = default( T );
         porthos = default( T );
         aramis = default( T );
      }
   }
}
