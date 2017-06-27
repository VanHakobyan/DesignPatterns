namespace SimpleSingleton
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Singleton inst1 = Singleton.Instance();
            Singleton inst2 = Singleton.Instance();
            Console.WriteLine(inst1.Equals(inst2));           //true
            Console.WriteLine(ReferenceEquals(inst1, inst2));  //true
        }
    }
}
