namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator=new ConcreteCreator();
            Product product=creator.FactoryMethod();
            creator.Operation();
        }
    }
}
