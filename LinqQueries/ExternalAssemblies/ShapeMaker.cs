using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shapes;

namespace LinqQueries.ExternalAssemblies
{
   class ShapeMaker
   {
      private List<BaseShape> shapes =  new List<BaseShape>();

      public ShapeMaker()
      {
         shapes.Add(new Hexigon());
         shapes.Add(new Triangle());
         shapes.Add(new Square());

         foreach( BaseShape shape in shapes)
            shape.Draw();
      }
   }
}
