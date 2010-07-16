using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultipleDataSets
{
   public partial class MainForm : Form
   {
      private DataSet autoLotDS = new DataSet( "AutoLot" );

      private SqlCommandBuilder inventoryCmd;
      private SqlCommandBuilder customerCmd;
      private SqlCommandBuilder ordersCmd;

      private SqlDataAdapter inventoryAdapter;
      private SqlDataAdapter customerAdapter;
      private SqlDataAdapter ordersAdapter;

      private string connectionStr = string.Empty;

      public MainForm()
      {
         InitializeComponent();
         SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
         {
            DataSource = @"(Local)\SQLEXPRESS",
            IntegratedSecurity = true,
            InitialCatalog = "AutoLot"
         };
         connectionStr = builder.ConnectionString;

         initializeTable( out inventoryAdapter, out inventoryCmd, "Inventory" );
         initializeTable( out customerAdapter, out customerCmd, "Customers" );
         initializeTable( out ordersAdapter, out ordersCmd, "Orders" );

         autoLotDS.Relations.Add( TableRelationship( "CustomerOrder", "CustID", "Customers", "Orders" ) );
         autoLotDS.Relations.Add( TableRelationship( "InventoryOrder", "CarID", "Inventory", "Orders" ) );

         inventoryDg.DataSource = autoLotDS.Tables["Inventory"];
         customersDg.DataSource = autoLotDS.Tables["Customers"];
         ordersDg.DataSource = autoLotDS.Tables["Orders"];
      }

      private void initializeTable(out SqlDataAdapter adapter, out SqlCommandBuilder builder, string tableName)
      {
         adapter = new SqlDataAdapter( "Select * from " + tableName, connectionStr );
         builder = new SqlCommandBuilder( adapter );
         adapter.Fill( autoLotDS, tableName );
      }

      private DataRelation TableRelationship(string name, string field, string table1, string table2)
      {
         return new DataRelation( name,
            autoLotDS.Tables[table1].Columns[field],
            autoLotDS.Tables[table2].Columns[field] );
      }

      private void OnDbUpdate(object sender, EventArgs e)
      {
         try
         {
            inventoryAdapter.Update( autoLotDS, "Inventory" );
            inventoryAdapter.Update( autoLotDS, "Customers" );
            inventoryAdapter.Update( autoLotDS, "Orders" );
         }
         catch (Exception ex)
         {
            MessageBox.Show( ex.Message );
         }
      }

      private void OnGetOrder(object sender, EventArgs e)
      {
         int custID = int.Parse( customerIdTxt.Text );
         DataRow[] customerRows = autoLotDS.Tables["Customers"].Select( "CustID = " + custID );

         string orderInfo = string.Format( "Customer {0}: {1} {2}\n",
            customerRows[0]["CustID"].ToString(),
            customerRows[0]["FirstName"].ToString().Trim(),
            customerRows[0]["LastName"].ToString().Trim()
         );

         DataRow[] orderRows = customerRows[0].GetChildRows( autoLotDS.Relations["CustomerOrder"] );

         foreach (DataRow row in orderRows)
            orderInfo += string.Format( "Order Number: {0}\n", row["OrderID"] );

         DataRow[] inventoryRows = orderRows[0].GetParentRows( autoLotDS.Relations["InventoryOrder"] );

         foreach (DataRow row in inventoryRows)
         {
            orderInfo += string.Format( "Make: {0}\n", row["Make"] );
            orderInfo += string.Format( "Color: {0}\n", row["Color"] );
            orderInfo += string.Format( "Pet Name: {0}\n", row["PetName"] );
         }

         MessageBox.Show( orderInfo, "Order Details" );
      }
   }
}
