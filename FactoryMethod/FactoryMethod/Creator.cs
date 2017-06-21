namespace FactoryMethod
{
    abstract class Creator
    {
        Product product;
        public abstract Product FactoryMethod();
        public void Operation()
        {
            product = FactoryMethod();
        }
    }
}
