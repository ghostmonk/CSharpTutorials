using System;

namespace PolymorpAndParitals.PolyMorphism.Corporation
{
   public abstract partial class Employee
   {
      private string EmpName;
      private int EmpID;
      private int EmpAge;
      private float CurPay;
      private string EmpSSN;
      private static string CompanyName;
      private BenefitPackage EmpBenefits;

      public double GetBenefitCost()
      {
         return EmpBenefits.ComputePayByDeduction();
      }

      public virtual void GiveBonus( float amount )
      {
         CurPay += amount;
      }

      public class BenefitPackage
      {
         public double ComputePayByDeduction()
         {
            return 125.0;
         }

         public enum BenefitsLevel
         {
            Standard, Gold, Platinum
         }
      }

      public void DisplayStats()
      {
         Console.WriteLine( "Name {0}: ", EmpName );
         Console.WriteLine( "ID: {0}", EmpID );
         Console.WriteLine( "Age: {0}", EmpAge );
         Console.WriteLine( "SSN: {0}", EmpSSN );
         Console.WriteLine( "Current Pay: {0}", CurPay );
         Console.WriteLine();
      }
   }
}
