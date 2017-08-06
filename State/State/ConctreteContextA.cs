using System;

namespace State
{
    internal class ConctreteContextA : State
    {
        internal override void Handle(Context context)
        {
            context.State = new ConctreteContextB();
            Console.WriteLine("Go to state B");
        }
    }
}