using System;

namespace ProxySurrogate
{
    class Operator : IHuman
    {
        public void Request()
        {
            Console.WriteLine("Operator");
        }
    }
}
