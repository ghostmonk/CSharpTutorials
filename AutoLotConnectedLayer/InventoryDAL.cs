using System;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotConnectedLayer
{
   public class InventoryDAL
   {
      private SqlConnection connection = new SqlConnection();

      public void OpenConnection(string connectionString)
      {
         connection.ConnectionString = connectionString;
         connection.Open();
      }

      public void ProcessCreditRisk(bool throwEx, int custID)
      {
         string fName = string.Empty;
         string lName = string.Empty;

         string cmdString = string.Format("Select * From Customers where CustID = {0}", custID);
         SqlCommand command = new SqlCommand(cmdString, connection);

         using (SqlDataReader reader = command.ExecuteReader())
         {
            while (reader.Read())
            {
               fName = reader["FirstName"].ToString().Trim();
               lName = reader["LastName"].ToString().Trim();
            }
         }

         string insertString = string.Format("Insert Into CreditRisks(CustID, FirstName, LastName) Values({0}, '{1}', '{2}')", custID, fName, lName);
         string rmvString = string.Format("Delete from Customers where CustID = {0}", custID);

         SqlCommand insertCommand = new SqlCommand(insertString, connection);
         SqlCommand removeCommand = new SqlCommand(rmvString, connection);

         SqlTransaction transaction = null;

        try
        {
            transaction = connection.BeginTransaction();

            insertCommand.Transaction = transaction;
            removeCommand.Transaction = transaction;

            insertCommand.ExecuteNonQuery();
            removeCommand.ExecuteNonQuery();
            
            if(throwEx)
               throw new ApplicationException("Sorry! Database error! Transaction failed.");

            transaction.Commit();
            
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
            transaction.Rollback();
         }
      }

      public string LookUpPetName(int carID)
      {
         string carPetName = string.Empty;

         using(SqlCommand command = new SqlCommand("GetPetName", connection))
         {
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter inParam = GetAutoParam("@carID", carID, SqlDbType.Int, 0);
            inParam.Direction = ParameterDirection.Input;
            command.Parameters.Add(inParam);

            SqlParameter outParam = new SqlParameter();
            outParam.ParameterName = "@petName";
            outParam.SqlDbType = SqlDbType.Char;
            outParam.Size = 10;
            outParam.Direction = ParameterDirection.InputOutput;

            command.Parameters.Add(outParam);
            command.ExecuteNonQuery();

            carPetName = ((string) command.Parameters["@petName"].Value).Trim();
         }
         return carPetName;
      }

      public void InsertAuto(int id, string color, string make, string petName)
      {
         string cmdString = "Insert Into Inventory(CarID, Make, Color, PetName) Values(@CarID, @Make, @Color, @PetName)";
         using (SqlCommand command = new SqlCommand( cmdString, connection ))
         {
            command.Parameters.Add( GetAutoParam( "@CarID", id, SqlDbType.Int, 0 ) );
            command.Parameters.Add( GetAutoParam( "@Make", make, SqlDbType.Char, 10 ) );
            command.Parameters.Add( GetAutoParam( "@Color", color, SqlDbType.Char, 10 ) );
            command.Parameters.Add( GetAutoParam( "@PetName", petName, SqlDbType.Char, 10 ) );
            command.ExecuteNonQuery();
         }
      }

      public SqlParameter GetAutoParam(string name, object value, SqlDbType type, int size)
      {
         SqlParameter param = new SqlParameter();
         param.ParameterName = name;
         param.Value = value;
         param.SqlDbType = type;
         if (size > 0) param.Size = size;
         return param;
      }

      public void DeleteCar(int id)
      {
         string cmdString = string.Format("Delete from Inventory where CarID = '{0}'", id);
         using(SqlCommand command = new SqlCommand(cmdString, connection))
         {
            try
            {
               command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               Exception error = new Exception("Sorry! That car is on order!", ex);
               throw error;
            }   
         }
      }

      public void UpdateCarPetName(int id, string newPetName)
      {
         string cmdString = string.Format("Update Inventory Set PetName = '{0}' Where CarID = '{1}'", newPetName, id);
         using(SqlCommand command = new SqlCommand(cmdString, connection))
         {
            command.ExecuteNonQuery();
         }
      }

      public DataTable GetCompleteInventory()
      {
         DataTable inventory = new DataTable();

         string cmdString = "Select * From Inventory";
         using(SqlCommand command = new SqlCommand(cmdString, connection))
         {
            SqlDataReader reader = command.ExecuteReader();
            inventory.Load(reader);
            reader.Close();
         }

         return inventory;
      }

      public void CloseConnection()
      {
         connection.Close();
      }
   }
}