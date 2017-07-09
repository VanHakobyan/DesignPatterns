namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int exState = 0;
            AbstractFlyweight flyweight = null;
            FlyweightFactory factory = new FlyweightFactory();

            flyweight = factory.GetFlyweight("1");
            flyweight.Operation(exState);

            flyweight = factory.GetFlyweight("10");
            flyweight.Operation(exState);

            flyweight = new UnsharedConctreteFlyweight();
            flyweight.Operation(exState);
        }
    }
}
