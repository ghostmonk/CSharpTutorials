using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace DataProviderFactory
{
   class Program
   {
      static void Main(string[] args)
      {
         //new CarInventoryConnection();
         new ConnectedLayer();
         Console.ReadLine();
      }
   }
}
