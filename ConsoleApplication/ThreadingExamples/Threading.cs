namespace ConsoleApplication.ThreadingExamples
{
    internal class Threading
    {
        public static void Execute()
        {
            Console.WriteLine("Thread Started");
            var tread = new Thread(new ThreadStart(doWork));
            tread.IsBackground = true;
            tread.Start();

            var tread1 = new Thread(new ThreadStart(doWork));
            tread1.Start();

            var tread2 = new Thread(new ThreadStart(doWork));
            tread2.Start();
            Console.WriteLine("Thread Ended");
        }

        private static Random random = new Random();
        private static int total = 0;
        public static void doWork()
        {
            int myTotal = total;
            Thread.Sleep(random.Next(1, 500));
            Console.WriteLine($"Doing Work: {total} for {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
