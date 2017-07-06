using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.OperacionAB();
            Console.WriteLine(new string('-',50));
            facade.OperacionAC();
            Console.WriteLine(new string('-',50));
            facade.OperacionBC();
            Console.WriteLine(new string('-',50));
            facade.OperacionABC();
            Console.WriteLine(new string('-',50));
        }
    }
}
