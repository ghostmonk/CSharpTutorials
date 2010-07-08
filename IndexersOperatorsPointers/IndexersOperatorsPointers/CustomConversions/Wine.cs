namespace IndexersOperatorsPointers.IndexersOperatorsPointers.CustomConversions
{
   class Wine
   {
      private WineType type;

      public Wine(WineType type)
      {
         this.type = type;   
      }

      public int TempInCelcius
      {
         get; set;
      }

      public float NumberOfLiters
      {
         get; set;
      }

      public WineType Type
      {
         get { return type; }
      }

      public override string ToString()
      {
         return string.Format( "Type: {0}, Number of Liters:{1}, Temperature:{2}", Type, NumberOfLiters, TempInCelcius );
      }
   }

   public enum WineType
   {
      bordeaux, merlot, cabernet, pinoNoir
   }
}
