using System;

namespace DocoratorCarlson
{
    class Propeller:Decorator
    {
        void Behavior()
        {
            Console.WriteLine("New Behavior");
        }
        public override void Operation()
        {
            base.Operation();
            Behavior();
        }
    }
}
