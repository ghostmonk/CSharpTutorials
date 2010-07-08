using System;
using System.Collections;
using ExceptionsErrors.Errors;

namespace CollectionsGenerics.CollectionsGenerics.Collections
{
   class OriginalCollections
   {
      private Car[] CAR_BANK = new Car[]
                                       {
                                          new Car("Willy", 20),
                                          new Car("Herbie", 90),
                                          new Car("Betsie", 65 ),
                                          new Car("George",45),
                                          new Car("BOB", 10 )
                                       };

      public OriginalCollections()
      {
         Console.WriteLine( "\n*************ArrayList Test*****************" );
         ArrayListTest();
         Console.WriteLine( "\n*************Queue Test*****************" );
         QueueTest();
         Console.WriteLine( "\n*************Stack Test*****************" );
         StackTest();
      }

      private void QueueTest()
      {
         Queue queue = new Queue();
         queue.Enqueue( CAR_BANK[0] );
         queue.Enqueue( CAR_BANK[1] );
         queue.Enqueue( CAR_BANK[2] );
         
         ((Car)queue.Peek()).Display();
         DeQueued( (Car)queue.Dequeue() );

         ((Car)queue.Peek()).Display();
         DeQueued( (Car)queue.Dequeue() );

         ((Car)queue.Peek()).Display();
         DeQueued( (Car)queue.Dequeue() );

         try
         {
            ((Car)queue.Peek()).Display();
            DeQueued( (Car)queue.Dequeue() );
         }
         catch (Exception e)
         {
            Console.WriteLine( "Error!:{0}", e.Message );
         }
      }

      private void DeQueued( Car car )
      {
         car.Display();
      }

      private void StackTest()
      {
         Stack stack = new Stack();
         stack.Push( CAR_BANK[0] );
         stack.Push( CAR_BANK[1] );
         stack.Push( CAR_BANK[2] );

         ((Car)stack.Peek()).Display();
         ((Car)stack.Pop()).Display();

         ((Car)stack.Peek()).Display();
         ((Car)stack.Pop()).Display();

         ((Car)stack.Peek()).Display();
         ((Car)stack.Pop()).Display();

         try
         {
            ((Car)stack.Peek()).Display();
            ((Car)stack.Pop()).Display();
         }
         catch (Exception e)
         {
            Console.WriteLine("Error!:{0}", e.Message);
         }
      }

      private void ArrayListTest()
      {
         ArrayList list = new ArrayList();
         list.AddRange( 
            new Car[]
               {
                  CAR_BANK[0], 
                  CAR_BANK[1],
                  CAR_BANK[2]
               });
         Console.WriteLine("Number of cars = {0}", list.Count);

         foreach ( Car car in list )
            car.Display();
         Console.WriteLine();

         list.Insert( 2, CAR_BANK[3] );

         foreach (Car car in list)
            car.Display();
         Console.WriteLine();

         list[0] = CAR_BANK[4];

         foreach (Car car in list)
            car.Display();
      }
   }
}
