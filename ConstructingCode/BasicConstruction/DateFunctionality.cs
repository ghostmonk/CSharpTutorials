using System;

namespace ConstructingCode.BasicConstruction
{
   class DateFunctionality
   {
      public DateFunctionality()
      {
         DateTime dt = new DateTime(2004, 10, 17);
         Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
         dt = dt.AddMonths(2);
         Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

         TimeSpan timeSpan = new TimeSpan(4, 30, 0);
         Console.WriteLine(timeSpan);
         Console.WriteLine(timeSpan.Subtract(new TimeSpan(0,15,0)));
      }
   }
}
