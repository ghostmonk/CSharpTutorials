using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoLotConnectedLayer;

namespace MiscADO.Transations
{
   class TransactionManagement
   {
      public TransactionManagement()
      {
         bool throwEx = true;

         Console.WriteLine("Do you want to throw an exception (Y or N)");
         string userAnswer = Console.ReadLine();

         if (userAnswer.ToLower() == "n")
            throwEx = false;

         InventoryDAL inventory = new InventoryDAL();
         inventory.OpenConnection(@"Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AutoLot");

         inventory.ProcessCreditRisk(throwEx, 333);
      }
   }
}
