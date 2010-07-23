using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MagicEightBallWcfService
{
   [ServiceContract(Namespace = "http://www.ghostmonk.com")]
   public interface IEightBall
   {
      [OperationContract]
      string ObtainAnswer( string userQuestion );
   }
}
