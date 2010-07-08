using System;

namespace ConstructingCode.AdvancedConstruction.valueRef
{
   class Person
   {
      public Person( string name, int age)
      {
         Name = name;
         Age = age;
      }
      public Person() { }

      public string Name
      {
         get;
         set;
      }

      public int Age
      {
         get; set;
      }

      public void Display()
      {
         Console.WriteLine("Name: " + Name + " Age: " + Age );
      }
   }
}
