using System;

namespace State
{
    internal class ConctreteContextB : State
    {
        internal override void Handle(Context context)
        {
            context.State = new ConctreteContextA();
            Console.WriteLine("Go to state A");
        }
    }
}