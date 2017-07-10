using System;

namespace ChainOfResponsibility
{
    class ConcreteHandler2 : AbstractHandler
    {
        public override void RequestHandler(int request)
        {
            if (request == 2)
                Console.WriteLine("two");
            else if (Succsesor != null)
                Succsesor.RequestHandler(request);
        }
    }
}
