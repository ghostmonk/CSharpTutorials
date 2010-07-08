using System;
using ConstructingCode.AdvancedConstruction.helpers;
using ConstructingCode.AdvancedConstruction.shapeRefEx;
using ConstructingCode.AdvancedConstruction.valueRef;

namespace ConstructingCode.AdvancedConstruction
{
   class StructureExercises
   {
      public StructureExercises()
      {
         Point point = new Point {X = 300, Y = 400};
         PointRef pointRef = new PointRef( 300, 400 );

         readPoint( point );
         Console.WriteLine();
         readPoint(pointRef);

         MillionDollarQuestion();
         PersonRef();
      }

     private void readPoint( IPoint point )
      {
         IPoint cpyPoint = point;

         point.Display();
         cpyPoint.Display();
         
         point.Decrement();
         
         point.Display();
         cpyPoint.Display();
         
         point.Increment();
         point.Display();
         cpyPoint.Display();
      }

      public void MillionDollarQuestion()
      {
         Rectangle rect = new Rectangle("I am a rectangle", 10, 10, 10, 10);
         Rectangle rect2 = rect;

         rect.Display();
         rect2.Display();

         Console.WriteLine();
         rect2.Info.Info = "I am the second rect";

         rect.Display();
         rect2.Display();

         Console.WriteLine();
         rect2.Info = new ShapeInfo( "I am a new setting" );

         rect.Display();
         rect2.Display();
      }

      private void PersonRef()
      {
         Person john = new Person("John", 65);
         john.Display();
         SetPersonByValue( john );
         john.Display();
         SetPersonByRef(ref john);
         john.Display();
      }

      private void SetPersonByValue(Person person)
      {
         person.Age = 99;
         person = new Person( "Nikki", 99 );
      }

      private void SetPersonByRef( ref Person person)
      {
         person.Age = 88;
         person = new Person( "Nikki", 22 );
      }

      private struct Point : IPoint
      {
         public int X
         {
            get;
            set;
         }

         public int Y
         {
            get;
            set;
         }

         public void Increment()
         {
            X++;
            Y++;
         }

         public void Decrement()
         {
            Y--;
            X--;
         }

         public void Display()
         {
            Console.WriteLine( "X: " + X +" Y: " + Y );
         }
      }
   }
}
