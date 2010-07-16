using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualDataGridView
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
         this.inventoryTableAdapter.Fill( this.inventoryDataSet.Inventory );

      }

      private void OnGridUpdate(object sender, EventArgs e)
      {
         inventoryTableAdapter.Update( inventoryDataSet.Inventory );
         inventoryTableAdapter.Fill( inventoryDataSet.Inventory );
      }

      private void OnAddRow(object sender, EventArgs e)
      {
         inventoryTableAdapter.Insert( int.Parse( idTxt.Text ), makeTxt.Text, colorTxt.Text, nameTxt.Text );
         inventoryTableAdapter.Fill( inventoryDataSet.Inventory );
      }
   }
}
