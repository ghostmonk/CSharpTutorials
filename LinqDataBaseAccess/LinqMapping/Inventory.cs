using System.Data.Linq.Mapping;

namespace LinqDataBaseAccess.LinqMapping
{
   [Table]
   class Inventory
   {
      [Column]
      public string Make { get; set; }

      [Column]
      public string Color { get; set; }

      [Column]
      public string PetName { get; set; }

      [Column( IsPrimaryKey = true )]
      public int CarID { get; set; }

      public override string ToString()
      {
         return string.Format( "ID = {0}, Make = {1}, Color = {2}, PetName = {3}", 
            CarID, Make.Trim(), Color.Trim(), PetName.Trim() );
      }
   }
}
