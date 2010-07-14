using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MiscADO.AsyncCmdObject;
using MiscADO.introADO;
using MiscADO.Transations;

namespace MiscADO
{
   class Program
   {
      static void Main(string[] args)
      {
         //new ConnectionFactory();
         //new AsyncConnect();
         new TransactionManagement();
         Console.ReadLine();
      }
   }
}
