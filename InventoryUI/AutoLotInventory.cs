using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoLotConnectedLayer;

namespace InventoryUI
{
   public partial class AutoLotInventory : Form
   {
      private AutoLotDisconnectedLayer autoLot = null;

      public AutoLotInventory()
      {
         InitializeComponent();
         SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
         {
            DataSource = @"(Local)\SQLEXPRESS",
            IntegratedSecurity = true,
            InitialCatalog = "AutoLot"
         };
         autoLot = new AutoLotDisconnectedLayer( builder.ConnectionString );
         inventoryDG.DataSource = autoLot.GetAllInventory();
      }

      private void OnInventoryUpdate(object sender, EventArgs e)
      {
         DataTable table = (DataTable) inventoryDG.DataSource;
         autoLot.UpdateInventory(table);
      }
   }
}
