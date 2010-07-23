using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LinqDataBaseAccess.LinqMapping
{
   class LinqToSql
   {
      public LinqToSql()
      {
         SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
         {
            DataSource = @"(local)\SQLEXPRESS", 
            InitialCatalog = "AutoLot", 
            IntegratedSecurity = true
         };

         AutoLotDataBase autoDb = new AutoLotDataBase( builder.ConnectionString );
         autoDb.ShowAll();
         autoDb.ShowMake("Ford");
      }
   }
}
