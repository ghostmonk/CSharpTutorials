using System;

namespace IndexersOperatorsPointers.IndexersOperatorsPointers.CustomConversions
{
   class Water
   {
      private WaterType type;

      public Water( WaterType type )
      {
         this.type = type;   
      }

      public static implicit operator Wine(Water water)
      {
         Wine wine = new Wine( (WineType)(int)water.Type );
         wine.TempInCelcius = 10;
         wine.NumberOfLiters = water.NumberOfLiters / 2;
         return wine;
      }

      public static implicit operator Water(Wine wine)
      {
         Water water = new Water( (WaterType)(int)wine.Type );
         water.TempInCelcius = wine.TempInCelcius;
         water.NumberOfLiters = wine.NumberOfLiters * 2;
         return water;
      }

      public static implicit operator Water(int value)
      {
         int constrained = Math.Max( 0, Math.Min( value, typeof( WaterType ).GetEnumNames().Length - 1 ) );
         return new Water( (WaterType)constrained );
      }

      public static implicit operator Water(WaterType type)
      {
         return new Water( type );
      }

      public int TempInCelcius
      {
         get; set;
      }

      public float NumberOfLiters
      {
         get; set;
      }

      public WaterType Type
      {
         get { return type; }
      }

      public override string ToString()
      {
         return string.Format("Type: {0}, Number of Liters:{1}, Temperature:{2}", Type, NumberOfLiters, TempInCelcius);
      }
   }

   public enum WaterType
   {
      salt, fresh, spring, sewer
   }
}
