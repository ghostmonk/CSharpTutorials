using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MagicEightBallWcfService
{
   public class MagicEightBallService : IEightBall
   {
      public MagicEightBallService()
      {
         Console.WriteLine( "The 8-ball awaits your question." );
      }

      public string ObtainAnswer( string userQuestion )
      {
         string[] answers = { "Future Uncertain", "Yes", "No", "Hazy", "Ask Again Later", "Definitely" };
         Random rand = new Random();
         return string.Format( "{0}? {1}.", userQuestion, answers[rand.Next( answers.Length )] );
      }
   }
}
