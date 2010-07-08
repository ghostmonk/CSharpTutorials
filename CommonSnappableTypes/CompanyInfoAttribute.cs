using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonSnappableTypes
{
   public interface IAppFunctionality
   {
      void DoIt();
   }

   public sealed class CompanyInfoAttribute : System.Attribute
   {
      public string Name
      {
         get; set;
      }

      public string Url
      {
         get; set;
      }
   }
}
