using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MagicEightBallServiceClient.ServiceReference;

namespace MagicEightBallServiceClient
{
   class Program
   {
      static void Main( string[] args )
      {
         Console.WriteLine( "*********Ask The Magic EightBall*********" );

         using( EightBallClient eightBall = new EightBallClient() )
         {
            Console.WriteLine( "Your question: " );
            string question = Console.ReadLine();
            string answer = eightBall.ObtainAnswer( question );
            Console.WriteLine( "8-Ball says: {0}", answer );
         }
         Console.ReadLine();
      }
   }
}
