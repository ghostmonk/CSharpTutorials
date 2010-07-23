using System;
using System.Data.Linq;
using System.Linq;

namespace LinqDataBaseAccess.LinqMapping
{
   internal class AutoLotDataBase : DataContext
   {
      public AutoLotDataBase( string connectionString )
         : base( connectionString )
      {
         Inventory = GetTable<Inventory>();
      }

      public Table<Inventory> Inventory { get; set; }

      public void ShowAll()
      {
         foreach( Inventory item in ( from items in Inventory select items ) )
            Console.WriteLine( item.ToString() );
      }

      public void ShowMake( string make )
      {
         Console.WriteLine("\n***************Showing Make {0}*************", make);
         IOrderedQueryable<Inventory> targetCar =
            from car in Inventory
            where car.Make == make
            orderby car.CarID
            select car;

         foreach( Inventory foundCar in targetCar )
            Console.WriteLine( foundCar.ToString() );
      }
   }
}