namespace ProxySurrogate
{
    class Program
    {
        static void Main(string[] args)
        {
            IHuman Bruce = new Operator();
            Surrogate surrogate = new Surrogate(Bruce);
            surrogate.Request();
        }
    }
}
