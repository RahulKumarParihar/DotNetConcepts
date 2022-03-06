namespace ConsoleApplication.TaskExamples
{
    internal class TPL
    {
        public static void Execute()
        {
            ParallelFor();
            ParallelForEach();
        }

        private static void ParallelFor()
        {
            Console.WriteLine("Parallel For");
            Parallel.For(0, 100, (t) => { Console.Write($"{t} "); });
            Console.WriteLine();
        }

        private static void ParallelForEach()
        {
            Console.WriteLine("Parallel ForEach");
            List<int> list = new List<int>();
            for(int i = 0; i < 100; i++) list.Add(i);
            Parallel.ForEach(list, (t) => { Console.Write($"{t} "); });
        }
    }
}
