using System;

namespace ExceptionsErrors.Errors
{
   public class Radio
   {
      private bool _isOn;

      public void CrankTunes( bool val )
      {
         _isOn = val;
         if (_isOn)
            Console.WriteLine( "Sweet sweet music." );
         else
            Console.WriteLine( "Sound if off." );
      }

      public bool IsOn
      {
         get { return _isOn; }
      }
   }
}
