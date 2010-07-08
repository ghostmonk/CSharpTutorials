using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegatesEventsLambdas.DelegatesEventsLambdas.Delegates
{
   class NuclearReactor
   {
      private const double HEAT_INCREASE_QUOTIENT = 1000;
      private readonly double deathTemp;
      private readonly double warningTemp;
      private double currentTemp;
      private double controlRodHeight;
      private long energyCapacity;
      private double heatIncrease;
      private double reactorSize;
      private double controlRodMaxHeight;
      private Timer timer;

      private ReactorObserver observer;

      public NuclearReactor( NuclearReactorType capacity )
      {
         observer = new ReactorObserver();

         controlRodHeight = 0;
         energyCapacity = (long) capacity;
         reactorSize = energyCapacity * 0.05;
         controlRodMaxHeight = reactorSize * 10;
         deathTemp = energyCapacity * 5;
         warningTemp = deathTemp * 0.9;
      }

      public ReactorObserver Observer
      {
         get { return observer; }
      }

      public double EnergyCapacity
      {
         get { return energyCapacity; }
      }

      public double CurrentTemp
      {
         get { return currentTemp; }
      }

      public double MaxControlRodHeight
      {
         get { return controlRodMaxHeight; }
      }

      public void StartReactor()
      {
         timer = new Timer( OnTimer );
         timer.Change(100, 100);
      }

      public void RaiseControlRod( double amt )
      {
         controlRodHeight += amt;
         UpdateCurrentTemp();
      }

      public void LowerControlRod( double amt )
      {
         heatIncrease /= 1.5;
         controlRodHeight -= amt;
         UpdateCurrentTemp();
      }

      public void CoolReactor()
      {
         Console.WriteLine( "Emergency Cooling Phase" );
      }

      public void Display()
      {
         Console.WriteLine( "Death Temperature: {0}", deathTemp );
         Console.WriteLine( "Warning Temperature: {0}", warningTemp );
         Console.WriteLine( "Current Temp: {0}", currentTemp );
         Console.WriteLine( "Control Rod Height: {0}", controlRodMaxHeight );
         Console.WriteLine( "Reactor Size: {0}", reactorSize );
      }

      private void OnTimer(Object obj)
      {
         IncrementTemperature();

         if (currentTemp >= deathTemp)
         {
            timer.Dispose();
            observer.OnMeltDown("Chernobyl is happening, you're dead!");
            return;
         }

         if (currentTemp >= warningTemp)
            observer.OnImminentDanger( "Shit is getting hot" );

      }

      private void UpdateCurrentTemp()
      {
         currentTemp = controlRodHeight;
         if(currentTemp > 0)
            currentTemp += heatIncrease;
         Console.WriteLine( "Current Temperature is {0}", currentTemp );
      }

      private void IncrementTemperature()
      {
         heatIncrease += HEAT_INCREASE_QUOTIENT;
         UpdateCurrentTemp();
      }
   }

   public enum NuclearReactorType : long
   {
      Small = 50000, Medium = 100000, Large = 500000
   }
}
