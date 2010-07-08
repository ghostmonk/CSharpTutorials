namespace PolymorpAndParitals.PolyMorphism.Corporation
{
   public partial class Employee
   {
      public Employee( string name, int age, int id, float pay, string ssn)
      {
         EmpBenefits = new BenefitPackage();
         EmpName = name;
         EmpAge = age;
         EmpID = id;
         CurPay = pay;
         EmpSSN = ssn;
      }

      public BenefitPackage Benefits
      {
         get { return EmpBenefits;  }
         set { EmpBenefits = value; }
      }

      public string Name
      {
         get { return EmpName; }
         set { EmpName = value; }
      }

      public int ID
      {
         get { return EmpID; }
         set { EmpID = value; }
      }

      public int Age
      {
         get { return EmpAge; }
         set { EmpAge = value; }
      }

      public float Pay
      {
         get { return CurPay; }
         set { CurPay = value; }
      }

      public static string Company
      {
         get { return CompanyName; }
         set { CompanyName = value; }
      }

      public string SSN
      {
         get { return EmpSSN; }
      }
   }
}
