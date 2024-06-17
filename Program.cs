namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton instance = Singleton.GetInstance();
            A a = new(instance);
            B b = new(instance);
        }
    }
    public class A
    {
        private readonly Singleton singleton;
        public A(Singleton instance)
        {
            this.singleton = instance;
        }

    }
    public class B
    {
        private readonly Singleton singleton;
        public B(Singleton instance)
        {
            this.singleton = instance;
        }
    }

    public class Singleton
    {
        private static Singleton singleton;
        private Singleton() { }
        public static Singleton GetInstance()
        {
            singleton ??= new Singleton();
            return singleton;
        }

    }
}
