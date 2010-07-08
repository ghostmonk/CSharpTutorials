using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using CommonSnappableTypes;
using SnappableGUI.Properties;

namespace SnappableGUI
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void File_OnSelectedIndexChanged(object sender, EventArgs e)
      {
         OpenFileDialog dialog = new OpenFileDialog();

         if( dialog.ShowDialog() == DialogResult.OK)
         {
            if (dialog.FileName.Contains( "CommonSnappableTypes" ))
               MessageBox.Show( Resources.MainForm_File_OnSelectedIndexChanged_CommonSnappableTypes_has_no_snap_ins_ );
            else if (!LoadExternalModule( dialog.FileName ))
               MessageBox.Show(Resources.MainForm_File_OnSelectedIndexChanged_Nothing_implements_IAppFunctionality_);
         }
      }

      private bool LoadExternalModule(string fileName)
      {
         bool foundSnapIn = false;
         Assembly snapIn;

         try
         {
            snapIn = Assembly.LoadFrom(fileName);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
            return foundSnapIn;
         }

         var classTypes = from type in snapIn.GetTypes()
                          where type.IsClass && (type.GetInterface( "IAppFunctionality" ) != null)
                          select type;

         foreach (Type classType in classTypes)
         {
            foundSnapIn = true;
            IAppFunctionality itfApp = (IAppFunctionality) snapIn.CreateInstance(classType.FullName, true);
            itfApp.DoIt();
            lstLoadedSnapIns.Items.Add(classType.FullName);
            DisplayCompanyData(classType);
         }
         return foundSnapIn;
      }

      private void DisplayCompanyData(Type classType)
      {
         var corpInfo = from ci in classType.GetCustomAttributes(false)  
                        where (ci.GetType() == typeof(CompanyInfoAttribute) )
                        select ci;
         foreach (CompanyInfoAttribute attribute in corpInfo)
            MessageBox.Show(attribute.Url, string.Format("More info about {0} can be found at", attribute.Name) );
      }
   }
}