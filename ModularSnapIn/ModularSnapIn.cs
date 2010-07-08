using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonSnappableTypes;

namespace ModularSnapIn
{
   [CompanyInfo(Name = "Ghostmonk Designs", Url = "www.ghostmonk.com")]
   public class SnapInModule : IAppFunctionality
   {
      public void DoIt()
      {
         MessageBox.Show("You snapped in a SnapInModule. That is very extensible of you!");
      }
   }
}
