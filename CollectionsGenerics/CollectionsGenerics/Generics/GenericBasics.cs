using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CollectionsGenerics.CollectionsGenerics.Generics.CustomTypes;
using ExceptionsErrors.Errors;

namespace CollectionsGenerics.CollectionsGenerics.Generics
{
   class GenericBasics
   {
      private Car[] CAR_BANK = new Car[]
      {
         new Car("Willy", 20),
         new Car("Herbie", 90),
         new Car("Betsie", 65 ),
         new Car("George",45),
         new Car("BOB", 10 )
      };

      public GenericBasics()
      {
         //SimpleList();
         //UsedGenericMethods();
         //RunCustomGenericTypes();
         RunCustomGenericCollection();
      }

      private void RunCustomGenericCollection()
      {
         PeriodicTable < Element > elements = new PeriodicTable<Element>();
         elements.AddElement( new Element( ElementType.Fluorine ) );
         elements.AddElement( new Element( ElementType.Carbon ) );
         elements.AddElement( new Element( ElementType.Lithium ) );

         foreach( Element element in elements )
            element.Display();
      }

      private void RunCustomGenericTypes()
      {
         Musketeers <Element> elements = new Musketeers<Element>(
            new Element(ElementType.Nitrogen),
            new Element(ElementType.Beryllium),
            new Element(ElementType.Neon));
         Console.WriteLine(elements);
      }

      private void SimpleList()
      {
         List<Car> cars = new List<Car>();
         cars.Add(CAR_BANK[0]);
         cars.AddRange(CAR_BANK);
         cars.ForEach( car => car.Display() );
      }

      private void UsedGenericMethods()
      {
         Element boron = new Element(ElementType.Boron);
         Element helium = new Element(ElementType.Helium);
         boron.Display();
         helium.Display();
         GenericMethods.Swap( ref boron, ref helium );
         boron.Display();
         helium.Display();

         GenericMethods.DisplayBaseClass<Element>();
      }
   }
}
