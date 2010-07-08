namespace PolymorpAndParitals.PolyMorphism.Corporation
{
   public class SalesPerson : Employee
   {
      private int _numberOfSales;

      public SalesPerson(string name, int age, int id, float pay, string ssn) 
         : base(name, age, id, pay, ssn)
      {
      }

      public string GetInfo()
      {
         return "Sales Person Info.";
      }

      public int NumberOfSales
      {
         get { return _numberOfSales; }
         set { _numberOfSales = value; }
      }

      public sealed override void GiveBonus(float amount)
      {
         base.GiveBonus( amount + _numberOfSales * 10 );
      }
   }
}
