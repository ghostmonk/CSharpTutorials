using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LinqDataBaseAccess.IdeGeneration;

namespace LinqDataBaseAccess.GeneratedFiles
{
   class LinqGen
   {
      private AutoLot autoLot;
      private AutoLotObjectsDataContext dataContext;

      public LinqGen()
      {
         SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
         {
            DataSource = @"(local)\SQLEXPRESS",
            InitialCatalog = "AutoLot",
            IntegratedSecurity = true
         };
         autoLot = new AutoLot( builder.ConnectionString );
         dataContext = new AutoLotObjectsDataContext( builder.ConnectionString );
         //InvokeStoredProcedure();
         //PrintOrder();
         //InsertNewCar();
         //UpdateCar();
         DeleteCar();
      }

      private void InvokeStoredProcedure()
      {
         int carID = 0;
         string petname = "";
         Console.Write( "EnterID: " );
         carID = int.Parse( Console.ReadLine() );

         autoLot.GetPetName( carID, ref petname );

         Console.WriteLine( "Car ID {0} has the petname: {1}", carID, petname );
      }

      private void PrintOrder()
      {
         int custID = 0;
         Console.Write( "Enter Customer ID: " );
         custID = int.Parse( Console.ReadLine() );

         var orders = from customer in autoLot.Customers
                      from order in customer.Orders
                      where customer.CustID == custID
                      select new { customer, order };

         foreach( var item in orders )
         {
            Console.WriteLine( "{0}, {1} is order ID # {2}",
               item.customer.FirstName.Trim(),
               item.customer.LastName.Trim(),
               item.order.OrderID );
            Console.WriteLine( "{0} bought Car ID # {1}.",
               item.customer.FirstName.Trim(), item.order.CarID );
         }

         Console.WriteLine( orders );
      }

      private void InsertNewCar()
      {
         IdeGeneration.Inventory inventory = new IdeGeneration.Inventory();

         Console.Write( "Insert Car Name: " );
         inventory.PetName = Console.ReadLine();

         Console.Write( "Insert Car Make: " );
         inventory.Make = Console.ReadLine();

         Console.Write( "Insert Color: " );
         inventory.Color = Console.ReadLine();

         Console.Write( "Insert ID: " );
         inventory.CarID = int.Parse( Console.ReadLine() );

         dataContext.Inventories.InsertOnSubmit( inventory );
         dataContext.SubmitChanges();
      }

      private void UpdateCar()
      {
         Console.WriteLine( "Enter Car ID to update: " );

         var carToUpdate = ( from car in dataContext.Inventories
                           where car.CarID == int.Parse( Console.ReadLine() )
                           select car ).First();

         Console.Write( "Updateing Car {0} ", carToUpdate.PetName );
         
         Console.WriteLine("New Color: ");
         carToUpdate.Color = Console.ReadLine();
         
         Console.WriteLine( "New Make: " );
         carToUpdate.Make = Console.ReadLine();

         Console.WriteLine( "New PetName: " );
         carToUpdate.PetName = Console.ReadLine();

         dataContext.SubmitChanges();
      }

      private void DeleteCar()
      {
         Console.Write("Insert CarID to delete: ");
         var carToDelete = ( from car in dataContext.Inventories
                             where car.CarID == int.Parse( Console.ReadLine() )
                             select car ).First();
         
         dataContext.Inventories.DeleteOnSubmit( carToDelete );
         dataContext.SubmitChanges();
      }
   }
}
