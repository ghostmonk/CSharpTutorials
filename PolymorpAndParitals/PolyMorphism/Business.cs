using System;
using PolymorpAndParitals.PolyMorphism.Corporation;

namespace PolymorpAndParitals.PolyMorphism
{
   class Business
   {
      private Manager _manager;
      private SalesPerson _salesGuy;
      private PTSalesPerson _temp;

      public Business()
      {
         _manager = new Manager("Jacob", 35, 1, 130000, "432754920");
         _salesGuy = new SalesPerson("Whilliem", 24, 2, 35000, "600562123");
         _temp = new PTSalesPerson("Joyce", 18, 3, 22000, "345785234");

         _manager.DisplayStats();
         _salesGuy.DisplayStats();
         _temp.DisplayStats();

         Console.WriteLine( _salesGuy.GetInfo() );
         Console.WriteLine( _temp.GetInfo() );
         Console.WriteLine( ( _temp as SalesPerson ).GetInfo() );
      }
   }
}
