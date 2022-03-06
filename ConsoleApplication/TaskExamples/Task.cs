namespace ConsoleApplication.TaskExamples
{
    internal class Task
    {
        public static void Execute()
        {
            DoWork();
        }

        private static void DoWork()
        {
            System.Threading.Tasks.Task task = new System.Threading.Tasks.Task(() => { Console.WriteLine("Do Work 1"); });
            task.Start();
            // To Run only when task ran successfully
            System.Threading.Tasks.Task task1 = task.ContinueWith(t => { Console.WriteLine("Continue With"); }, TaskContinuationOptions.OnlyOnRanToCompletion);

            System.Threading.Tasks.Task.WaitAll(task, task1);
        }
    }
}
