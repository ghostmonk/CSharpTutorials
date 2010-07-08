namespace PolymorpAndParitals.PolyMorphism.Corporation
{
   public class Manager : Employee
   {
      private int _numberOfOptions;

      public Manager(string name, int age, int id, float pay, string ssn) 
         : base(name, age, id, pay, ssn)
      {
      }

      public int NumberOfOptions
      {
         get { return _numberOfOptions; }
         set { _numberOfOptions = value; }
      }

      public override void GiveBonus(float amount)
      {
         base.GiveBonus( amount );
         _numberOfOptions += 1;
      }
   }
}
