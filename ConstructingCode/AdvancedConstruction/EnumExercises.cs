using System;
using System.Collections.Generic;

namespace ConstructingCode.AdvancedConstruction
{
   class EnumExercises
   {
      private static readonly Dictionary<EmpType, string> Bonus = PopulateBonuses();

      public EnumExercises()
      {
         Console.WriteLine( Bonus[EmpType.Contractor] );
         Console.WriteLine( Bonus[EmpType.Grunt] );
         Console.WriteLine( Bonus[EmpType.VicePresident] );
         Console.WriteLine( Bonus[EmpType.Manager] );
         Console.WriteLine( Enum.GetUnderlyingType( typeof( EmpType ) ) );
         Console.WriteLine( Enum.GetUnderlyingType( EmpType.VicePresident.GetType() ) );
         Console.WriteLine( EmpType.VicePresident.ToString() );
         Console.WriteLine( (byte)EmpType.VicePresident );
         
         EvaluateEnum(EmpType.VicePresident);
         EvaluateEnum(DayOfWeek.Wednesday);
         EvaluateEnum(ConsoleColor.Yellow);
      }

      private static Dictionary<EmpType, string> PopulateBonuses()
      {
         Dictionary<EmpType, string> output = new Dictionary<EmpType, string>();
         output[EmpType.Contractor] = "Contractor Bonus";
         output[EmpType.Grunt] = "Grunt Bonus";
         output[EmpType.VicePresident] = "VicePresident Bonus";
         output[EmpType.Manager] = "Manager Bonus";
         return output;
      }

      private enum EmpType : byte
      {
         Manager = 10,
         Grunt = 1, 
         Contractor = 100, 
         VicePresident = 9
      }

      private void EvaluateEnum( Enum e )
      {
         Console.WriteLine( "Name: " + e.GetType().Name );
         Console.WriteLine( "Underlying Type: " + Enum.GetUnderlyingType( e.GetType() ) );
         Array values = Enum.GetValues(e.GetType());

         for (int i = 0; i < values.Length; i++)
            Console.WriteLine("Name: {0}, Value:{0:D}", values.GetValue(i));
      }
   }
}
