namespace DocoratorCarlson
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCarlson carlon = new Carlson();
            Decorator overalls = new Оveralls();
            Decorator propeller = new Propeller();

            overalls.carlson = carlon;
            propeller.carlson = overalls;
            propeller.Operation();

        }
    }
}
