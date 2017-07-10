using System;

namespace ChainOfResponsibility
{
    class ConcreteHandler3:AbstractHandler
    {
        public override void RequestHandler(int request)
        {
            if (request == 3)
                Console.WriteLine("tree");
            else if (Succsesor != null)
                Succsesor.RequestHandler(request);
        }
    }
}
