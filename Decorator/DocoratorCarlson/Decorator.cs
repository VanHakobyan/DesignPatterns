namespace DocoratorCarlson
{
    abstract class Decorator : AbstractCarlson
    {
        public AbstractCarlson carlson { protected get; set; }

        public override void Operation()
        {
            if (carlson != null)
                carlson.Operation();
        }
    }
}
