namespace ConsoleApplication.OOPs
{
    public class OOP
    {
        public static void Execute()
        {
            Base c1 = new Child();
            Child c2 = new Child();
            c1.PrintHello();
            c2.PrintHello();
            c1.PrintHi();
            c2.PrintHi();
        }
    }

    public class Base
    {
        static Base()
        {
            Console.WriteLine("I'm Base Static Constructor");
        }

        public Base()
        {
            Console.WriteLine("I'm Base Constructor");
        }

        public void PrintHello()
        {
            Console.WriteLine("Hello, from Base");
        }

        public virtual void PrintHi()
        {
            Console.WriteLine("Hi, from Base");
        }
    }

    public class Child : Base
    {
        static Child() 
        {
            Console.WriteLine("I'm Child Static Constructor");
        }

        public Child()
        {
            Console.WriteLine("I'm Child Constructor");
        }

        public new void PrintHello()
        {
            Console.WriteLine("Hello, from Child");
        }

        public override void PrintHi()
        {
            Console.WriteLine("Hi, from Child");
        }
    }
}
