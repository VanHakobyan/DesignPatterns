using System;


namespace ChainOfResponsibility
{
    class ConcreteHandler1 : AbstractHandler
    {
        public override void RequestHandler(int request)
        {
            if (request == 1)
                Console.WriteLine("one");
            else if(Succsesor!=null)
                Succsesor.RequestHandler(request);
        }
    }
}
