using System;

namespace DocoratorCarlson
{
    class Оveralls : Decorator
    {
        string state = "Some State";

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(state);
        }
    }
}
