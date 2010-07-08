using System;
using System.Collections;

namespace ExceptionsErrors.Errors
{
   public class Driver
   {
      private Car _car;

      public Driver()
      {
         _car = new Car();
         _car.TurnOnRadio( true );

         while (!_car.IsDead)
            IncreaseSpeed( 5 );
         IncreaseSpeed( -1 );
      }

      private void IncreaseSpeed( int amt )
      {
         try
         {
            Console.WriteLine( "Driver going {0} MPH", _car.Speed );
            _car.Accelerate( amt );
         }
         catch (CarIsDeadException Error)
         {
            Error.Display();
         }
         catch( ArgumentOutOfRangeException Error )
         {
            Console.WriteLine(Error.Message);
            throw;
         }
      }
   }
}