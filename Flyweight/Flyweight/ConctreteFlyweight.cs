namespace Flyweight
{
    class ConctreteFlyweight : AbstractFlyweight
    {
        int inState;

        public override void Operation(int exState)
        {
            inState = exState;
        }
    }
}
