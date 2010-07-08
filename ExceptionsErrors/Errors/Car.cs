using System;
using System.Collections;

namespace ExceptionsErrors.Errors
{
   public class Car
   {
      private Radio _radio;
      private const int MAX_SPEED = 100;
      private const int ALERT_THRESHOLD = 10;
      private string _name;
      private int _speed;
      private bool _isDead;
      private ArrayList _clientSinks = new ArrayList();

      public Car() : this( "N/A", 0 ) {}

      public Car( string name, int initialSpeed )
      {
         _name = name;
         _speed = initialSpeed;
         _isDead = false;
         _radio = new Radio();
      }

      public void Advise( IEngineNotification sink )
      {
         _clientSinks.Add(sink);
      }

      public void UnAdvise( IEngineNotification sink )
      {
         _clientSinks.Remove(sink);
      }

      public Radio CarRadio
      {
         get { return _radio; }
      }

      public bool IsDead
      {
         get { return _isDead; }
      }

      public void TurnOnRadio( bool val )
      {
         _radio.CrankTunes( val );
      }

      public int Speed
      {
         get { return _speed; }
      }

      public void Accelerate( int value )
      {
         if( value < 0 ) throw new ArgumentOutOfRangeException( "You can't slow down once you've started Accelerating." );
         if (_isDead)
         {
            foreach ( IEngineNotification sink in _clientSinks )
               sink.Exploded("The Car is dead");
            return;
         }

         _speed += value;

         if( (MAX_SPEED - _speed ) <= ALERT_THRESHOLD )
            foreach (IEngineNotification sink in _clientSinks)
               sink.AboutToBlow( "The Car is about to blow" );

         if (_speed <= MAX_SPEED) return;
         
         _isDead = true;
         Console.WriteLine("Major engine blow out. The car is dead.");
      }

      public void AppendInfo( IDictionary info )
      {
         info.Add( "RadioOn", _radio.IsOn );
         info.Add( "Speed", Speed );
         info.Add( "Time", DateTime.Now );
      }

      public void Display()
      {
         Console.WriteLine( "Name: {0}, Speed: {1}", _name, _speed);
      }
   }
}
