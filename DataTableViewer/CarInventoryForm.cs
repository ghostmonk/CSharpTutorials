using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataTableViewer.Classes;

namespace DataTableViewer
{
   public partial class CarInventoryForm : Form
   {
      List<Car> listCars = new List<Car>();
      private DataTable inventory = new DataTable();
      private Boolean isBeemer = true;
      private DataView bmwData;

      public CarInventoryForm()
      {
         InitializeComponent();

         listCars.Add( new Car( "Tiny", "BMW", "Grey" ) );
         listCars.Add( new Car( "Chucky", "BMW", "Green" ) );
         listCars.Add( new Car( "Fox", "BMW", "Silver" ) );
         listCars.Add( new Car( "Frank", "Toyota", "Yellow" ) );
         listCars.Add( new Car( "SubZero", "Toyota", "White" ) );
         listCars.Add( new Car( "IcyChills", "Mercedes", "Red" ) );
         listCars.Add( new Car( "LilDevil", "Mercedes", "Black" ) );
         listCars.Add( new Car( "BettyBoop", "Ford", "Blue" ) );
         listCars.Add( new Car( "Reaper", "Ford", "Purple" ) );

         CreateDataTable();
         CreateDataView();
      }

      private void CreateDataView()
      {
         bmwData = new DataView( inventory );
         bmwData.RowFilter = "Make = 'BMW'";
         bmwDG.DataSource = bmwData;
      }

      private void CreateDataTable()
      {
         DataColumn makeColumn = new DataColumn( "Make", typeof( string ) );
         DataColumn colorColumn = new DataColumn( "Color", typeof( string ) );
         DataColumn nameColumn = new DataColumn( "PetName", typeof( string ) );
         nameColumn.Caption = "Pet Name";
         inventory.Columns.AddRange( new DataColumn[] { makeColumn, colorColumn, nameColumn } );

         foreach (Car car in listCars)
         {
            DataRow row = inventory.NewRow();
            row["Make"] = car.Make;
            row["Color"] = car.Color;
            row["PetName"] = car.Name;
            inventory.Rows.Add( row );
         }
         carInventoryDG.DataSource = inventory;
      }

      private void OnRemoveDataRow(object sender, EventArgs e)
      {
         try
         {
            inventory.Rows[(int.Parse( rowNumberTxt.Text ))].Delete();
            inventory.AcceptChanges();
         }
         catch (Exception ex)
         {
            MessageBox.Show( ex.Message );
         }
      }

      private void OnMakeView(object sender, EventArgs e)
      {
         string filterString = string.Format( "Make= '{0}'", makeTxt.Text );
         DataRow[] makes = inventory.Select( filterString, "PetName DESC" );

         if (makes.Length == 0)
            MessageBox.Show( "Sorry, no cars...", "Selection Error" );
         else
         {
            string make = "";
            for (int i = 0; i < makes.Length; i++)
            {
               DataRow temp = makes[i];
               make += temp["PetName"] + "\n";
            }
            MessageBox.Show( make, string.Format( "{0} type(s):", makeTxt.Text ) );
         }
      }

      private void ShowCarsWithIdGreaterThanFive()
      {
         DataRow[] properIDs = inventory.Select( "ID > 5" );
         string ids = "";
         for (int i = 0; i < properIDs.Length; i++)
         {
            DataRow temp = properIDs[i];
            ids += temp["PetName"] + "is ID " + temp["ID"] + "\n";
         }
         MessageBox.Show( ids, "Pet names of cars where ID > 5" );
      }

      private void OnChangeMake(object sender, EventArgs e)
      {
         string originMake = isBeemer ? "BMW" : "Lada";
         string changeMake = isBeemer ? "Lada" : "BMW"; 
         isBeemer = !isBeemer;
         string message = string.Format( "Are you sure you want to change {0} to {1}?", originMake, changeMake );
         DialogResult yesResult = MessageBox.Show( message, "Please Confirm!", MessageBoxButtons.YesNo );

         if (yesResult == DialogResult.Yes)
         {
            DataRow[] makes = inventory.Select(string.Format( "Make='{0}'", originMake ));
            foreach (DataRow row in makes)
               row["Make"] = changeMake;
         }
      }

      private void OnRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
      {
         using(SolidBrush brush = new SolidBrush(Color.Black))
         {
            e.Graphics.DrawString((e.RowIndex).ToString(),
               e.InheritedRowStyle.Font, brush,
               e.RowBounds.Location.X + 15,
               e.RowBounds.Location.Y + 4);
         }
      }
   }
}
