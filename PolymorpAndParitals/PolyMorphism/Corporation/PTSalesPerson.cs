namespace PolymorpAndParitals.PolyMorphism.Corporation
{
   sealed class PTSalesPerson : SalesPerson
   {
      public PTSalesPerson(string name, int age, int id, float pay, string ssn) 
         : base(name, age, id, pay, ssn)
      {
      }

      public string GetInfo()
      {
         return "PTSalesPerson Info";
      }
   }
}
