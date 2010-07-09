using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IsolatedStorageSaver.Utils;

namespace IsolatedStorageSaver
{
   public partial class IsoStorageInfoForm : Form
   {
      public IsoStorageInfoForm()
      {
         InitializeComponent();
      }

      private void StorageDeleter_Click(object sender, EventArgs e)
      {
         IsoDataUtils.DeleteUserAssemblyData();
      }

      private void SaveDataBtn_Click(object sender, EventArgs e)
      {
         IsoDataUtils.SaveUserAssemblyData( StorageFileNameField.Text, StorageSaveField.Text );
      }

      private void ReadStorageBtn_Click(object sender, EventArgs e)
      {
         StorageReadField.Text = IsoDataUtils.ReadUserAssemblyData( StorageFileNameField.Text );
      }
   }
}
