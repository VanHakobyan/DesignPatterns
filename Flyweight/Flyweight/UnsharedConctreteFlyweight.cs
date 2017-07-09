namespace Flyweight
{
    class UnsharedConctreteFlyweight : AbstractFlyweight
    {
        int allState;

        public override void Operation(int exState)
        {
            allState = exState;
        }
    }
}
