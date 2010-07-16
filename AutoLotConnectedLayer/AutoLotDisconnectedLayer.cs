using System.Data;
using System.Data.SqlClient;

namespace AutoLotConnectedLayer
{
   public class AutoLotDisconnectedLayer
   {
      private const string SelectAllConnectionStr = "Select * From Inventory";
      private string connectionString = string.Empty;
      private SqlDataAdapter adapter = null;

      public AutoLotDisconnectedLayer(string connectionString)
      {
         this.connectionString = connectionString;
         CreateAdapter();
      }

      public DataTable GetAllInventory()
      {
         DataTable inventory = new DataTable( "Inventory" );
         adapter.Fill( inventory );
         return inventory;
      }

      public void UpdateInventory(DataTable table)
      {
         adapter.Update( table );
      }

      private void CreateAdapter()
      {
         adapter = new SqlDataAdapter( SelectAllConnectionStr, connectionString );
         SqlCommandBuilder builder = new SqlCommandBuilder( adapter );
      }
   }
}
