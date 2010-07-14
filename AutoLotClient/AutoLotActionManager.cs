using System;
using System.Configuration;
using System.Data;
using AutoLotClient.Utils;
using AutoLotConnectedLayer;

namespace AutoLotClient
{
   class AutoLotActionManager
   {
      public AutoLotActionManager()
      {
         string connectionStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
         bool userDone = false;
         string userCommand = "";

         InventoryDAL inventory = new InventoryDAL();
         inventory.OpenConnection(connectionStr);

         try
         {
            ShowInstructions();
            do
            {
               Console.WriteLine("Insert New Instruction:");
               userCommand = Console.ReadLine();
               Console.WriteLine();

               switch(userCommand.ToUpper())
               {
                  case "I":
                     InsertNewCar(inventory);
                     break;
                  case "U":
                     UpdateCarPetName( inventory );
                     break;
                  case "D":
                     DeleteCar( inventory );
                     break;
                  case "L":
                     ListInventory( inventory );
                     break;
                  case "S":
                     ShowInstructions();
                     break;
                  case "P":
                     LookUpPetName( inventory );
                     break;
                  case "Q":
                     userDone = true;
                     break;
                  default:
                     break;
               }
            } while (!userDone);
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }
         finally
         {
            inventory.CloseConnection();
         }
      }

      private void LookUpPetName(InventoryDAL inventory)
      {
         Console.WriteLine( "Enter ID of Car to Lookup:" );
         int id = int.Parse( Console.ReadLine() );

         Console.WriteLine("Petname of {0} is {1}.", id, inventory.LookUpPetName(id));
      }

      private void ListInventory(InventoryDAL inventory)
      {
         DataTable table = inventory.GetCompleteInventory();
         Console.WriteLine(DbUtils.TableToString(table));
      }

      private void DeleteCar(InventoryDAL inventory)
      {
         Console.Write("Enter ID of Car to delete:");
         int id = int.Parse(Console.ReadLine());

         try
         {
            inventory.DeleteCar(id);
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }
      }

      private void UpdateCarPetName(InventoryDAL inventory)
      {
         Console.WriteLine("Enter Car ID:");
         int id = int.Parse( Console.ReadLine() );

         Console.WriteLine( "Enter A New Pet Name:" );
         string petName = Console.ReadLine();

         inventory.UpdateCarPetName(id, petName);
      }

      private void InsertNewCar(InventoryDAL inventory)
      {
         Console.WriteLine("Enter Car ID:");
         int id = int.Parse( Console.ReadLine() );

         Console.WriteLine("Enter Car Color:");
         string color = Console.ReadLine();

         Console.WriteLine("Enter Car Make:");
         string make = Console.ReadLine();

         Console.WriteLine("Enter Pet Name:");
         string petName = Console.ReadLine();

         inventory.InsertAuto(id, color, make, petName);
      }

      private void ShowInstructions()
      {
         Console.WriteLine( "I: Inserts a New Car." );
         Console.WriteLine( "U: Update an existing Car." );
         Console.WriteLine( "D: Delete an existing Car." );
         Console.WriteLine( "L: List Current Inventory." );
         Console.WriteLine( "S: Show Instructions." );
         Console.WriteLine( "P: Look Up Petname." );
         Console.WriteLine( "Q: Quit" );
      }
   }
}
