using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public void DoWork()
        {
            Debug.WriteLine("Hello World");
            Debug.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);
        }

        delegate void DoWorkEventHandler();

        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);
            DoWorkEventHandler doWorkEvent = new DoWorkEventHandler(DoWork);
            AsyncCallback callback = new AsyncCallback(CallbackFunction);

            IAsyncResult result = doWorkEvent.BeginInvoke(callback, doWorkEvent);

            result.AsyncWaitHandle.WaitOne();
        }

        public static void CallbackFunction(IAsyncResult result)
        {
            var a =  result.AsyncState as DoWorkEventHandler;
            a.EndInvoke(result);
        }
    }
}
