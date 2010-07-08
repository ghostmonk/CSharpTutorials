using System;

namespace ExceptionsErrors.Errors
{
   [Serializable]
   public class CarIsDeadException : ApplicationException
   {
      private const string MESSAGE =  "The car is dead. You can't Accelerate a dead car.";
      private Car _car;
      
      public CarIsDeadException( Car car ) : base( MESSAGE )
      {
         _car = car;
      }

      public override string HelpLink
      {
         get { return "http://www.mechanicsRUs.com"; }
      }

      public int Speed
      {
         get {return  _car.Speed; }
      }

      public DateTime Time
      {
         get { return DateTime.Now; }
      }

      public bool IsRadioOn
      {
         get { return _car.CarRadio.IsOn; }
      }

      public void Display()
      {
         Console.WriteLine( "The Car Threw an exception:" );
         Console.WriteLine( "Message: {0}", Message );
         Console.WriteLine( "Member Name: {0}", TargetSite );
         Console.WriteLine( "Class Defining Member: {0}", TargetSite.DeclaringType );
         Console.WriteLine( "Member Type: {0}", TargetSite.MemberType );
         Console.WriteLine( "Source: {0}", Source );
         Console.WriteLine( "Stack: {0}", StackTrace );
         Console.WriteLine( "Helplink: {0}", HelpLink );
         Console.WriteLine( "Speed: {0}", Speed );
         Console.WriteLine( "Radio On: {0}", IsRadioOn );
         Console.WriteLine( "Time: {0}", Time );
      }
   }
}