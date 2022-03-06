namespace ConsoleApplication.ThreadingExamples
{
    internal class ThreadPool
    {
        public static void Execute()
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId}");
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(DoWork));
            Console.WriteLine($"Main Thread {Thread.CurrentThread.IsBackground}");

            manualReset.WaitOne();
        }

        private static ManualResetEvent manualReset = new ManualResetEvent(false);

        public static void DoWork(object state)
        {
            Console.WriteLine($"DoWork Thread {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"DoWork Thread {Thread.CurrentThread.IsBackground}");

            manualReset.Set();  
        }
    }
}
