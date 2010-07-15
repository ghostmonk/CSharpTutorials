using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using AutoLotClient.Utils;
using MiscADO.AsyncCmdObject;
using MiscADO.DataSets;
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
         //new TransactionManagement();
         new SimpleDataSet();
         //new DataRowState();

         Console.ReadLine();
      }
   }
}
