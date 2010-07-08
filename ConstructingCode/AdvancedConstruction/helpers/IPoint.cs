namespace ConstructingCode.AdvancedConstruction.helpers
{
   interface IPoint
   {
      int Y { get; set; }
      int X{ get; set; }

      void Increment();
      void Decrement();
      void Display();
   }
}
