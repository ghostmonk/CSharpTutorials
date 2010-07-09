using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace MultiThreading.SyncDelegate
{
    public delegate int BinaryOp(int x, int y);

    class BinaryOperation
    {
        public BinaryOperation()
        {
            Console.WriteLine("***********Sync Delegate Review**********");
            ReadThread("Constructor Invoked");

            BinaryOp binOp = new BinaryOp(Addition);
            int x = 10;
            int y = 20;

            //UseBeginInvoke(binOp, x, y);
            //UseBasicCall(binOp, x, y);
            UseASyncCallBack(binOp, x, y);
            
        }

        private void UseASyncCallBack(BinaryOp binOp, int x, int y)
        {
            IAsyncResult asyncResult = binOp.BeginInvoke(x, y, OnAdditionComplete, "Piece of Data Transported Through IAsyncResult.");
            RunWaitHandle(asyncResult);
        }

        private void OnAdditionComplete(IAsyncResult asyncResult)
        {
            AsyncResult result = (AsyncResult)asyncResult;
            BinaryOp operation = (BinaryOp)result.AsyncDelegate;
            string transportData = (string)asyncResult.AsyncState;
            int answer = operation.EndInvoke(asyncResult);
            ReadThread(string.Format("Using Async Callback Result of operation is {0} : Transport Data is \"{1}\"", answer,transportData));
        }

        private void UseBasicCall(BinaryOp binOp, int x, int y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, binOp(x, y));
        }

        private void UseBeginInvoke(BinaryOp binOp, int x, int y)
        {
            IAsyncResult asyncRes = binOp.BeginInvoke(x, y, null, null); 
            //RunWaitHandle(asyncRes);
            RunIsCompletedCall(asyncRes);
            int answer = binOp.EndInvoke(asyncRes);
            Console.WriteLine("{0} + {1} = {2}", x, y, answer);
        }

        private void RunWaitHandle(IAsyncResult asyncRes)
        {
            while (!asyncRes.AsyncWaitHandle.WaitOne(1000,true))
            {
                ReadThread("AsyncWaitHandle.WaitOne");
            }
        }

        private void RunIsCompletedCall(IAsyncResult asyncRes)
        {
            while (!asyncRes.IsCompleted)
            {
                ReadThread("Using IsCompleted");
                Thread.Sleep(1000);
            }
        }

        private int Addition(int x, int y)
        {
            ReadThread("Addition() invoked on Thread");
            Thread.Sleep(5000);
            return x + y;
        }

        private void ReadThread(string msg)
        {
            Console.WriteLine("{0} : Thread = {1}", msg, Thread.CurrentThread.ManagedThreadId);
        }
    }
}
