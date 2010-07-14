using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using People;
using VBPeople;

namespace ConsumeLivingThings
{
   class Program
   {
      static void Main(string[] args)
      {
         AppSettingsReader appSettings = new AppSettingsReader();
         Console.WriteLine(appSettings.GetValue("appConStr", typeof(string)));

         Animal animal = new Bear();
         Person person = new Janitor();

         int numbOfTimes = (int) appSettings.GetValue("timesToSayHello", typeof (int));
         for( int i = 0; i < numbOfTimes; i++)
         {
            animal.Speak();
            person.Speak();
         }

         Console.ReadLine();
      }
   }
}
